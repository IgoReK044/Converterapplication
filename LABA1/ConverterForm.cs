using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Spire.Xls.Core.Spreadsheet;
using Spire.Xls.Core;
using System.Xml.Serialization;

namespace LABA1
{
    public enum FileType
    {
        Json,
        CSV,
        XML,
        XLSX
    }

    public partial class ConverterForm : Form
    {
        private string _filePath;
        private FileType _convertType;

        public ConverterForm(string filePath, FileType convertType)
        {
            InitializeComponent();

            _filePath = filePath;
            _convertType = convertType;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "(*.json; *.txt; *.xml)| *.json; *.txt; *.xml | All files(*.*) | *.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Engine engine = GetEngineData(_filePath, GetFileType(_filePath));

                SaveEngineData(saveFileDialog.FileName, engine, _convertType);
            }
        }

        private void SaveEngineData(string savePath, Engine engine, FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Json:
                    File.WriteAllText(savePath, JsonConvert.SerializeObject(engine));
                    break;
                case FileType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Engine));

                    using (FileStream fs = new FileStream(savePath, FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, engine);
                    }
                    break;
                case FileType.XLSX:
                    List <string> dataList = new List<string>() { engine.Power.ToString(), engine.TipDv, engine.TipTopl };
                    XLWorkbook workbook = new XLWorkbook();
                    var wsDetailedData = workbook.AddWorksheet("data");
                    wsDetailedData.Cell(1, 1).InsertTable(dataList);
                    workbook.SaveAs(savePath);
                    break;

                case FileType.CSV:
                    string saveData = $"{engine.Power},{engine.TipDv},{engine.TipTopl}\n";
                    File.WriteAllText(savePath, saveData);
                    break;

            }
        }

        private Engine GetEngineData(string filePath, FileType fileType)
        {
            string data = File.ReadAllText(filePath);

            switch (fileType)
            {
                case FileType.Json:
                    Engine engine = JsonConvert.DeserializeObject<Engine>(data);
                    return engine;
                case FileType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Engine));

                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        return (Engine) xmlSerializer.Deserialize(fs);
                    }
                case FileType.XLSX:
                    var wbook = new XLWorkbook(filePath);

                    var ws1 = wbook.Worksheet(1);

                    return new Engine
                    {
                        Power = Convert.ToInt32(ws1.Cell("A2").GetValue<string>()),
                        TipDv = ws1.Cell("A3").GetValue<string>(),
                        TipTopl = ws1.Cell("A4").GetValue<string>()
                    };
                    
                case FileType.CSV:
                    string[] elems = data.Split(' ');
                    return new Engine
                    {
                        Power = int.Parse(elems[0]),
                        TipDv = elems[1],
                        TipTopl = elems[2]
                    };

                default:
                    return new Engine();
            }
        }

        private FileType GetFileType(string filePath)
        {
            string[] splitedPath = filePath.Split('/');
            string fileName = splitedPath[splitedPath.Length - 1].Split('.')[1];

            switch (fileName)
            {
                case "json":
                    return FileType.Json;
                case "xml":
                    return FileType.XML;
                case "xlsx":
                    return FileType.XLSX;
            }

            return FileType.CSV;
        }

    }
}
