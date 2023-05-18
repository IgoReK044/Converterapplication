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
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace LABA1
{
    public partial class MainMenuForm : Form
    {
        private string _filePath = "";

        public bool IsFilePathExists => _filePath != "";

        public MainMenuForm()
        {
            InitializeComponent();
        }


        private void buttonSearcKonvert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "(*.json; *.txt; *.xml)| *.json; *.txt; *.xml | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
            }
        }

        private void ConvertToJSONButton_Click(object sender, EventArgs e)
        {
            if (IsFilePathExists == false) return;
            
            ConverterForm jsonConverterForm = new ConverterForm(_filePath, FileType.Json);
            jsonConverterForm.Show();


            Hide();
            
        }

        private void ConvertToCSVButton_Click(object sender, EventArgs e)
        {
            if (IsFilePathExists == false) return;

            ConverterForm jsonConverterForm = new ConverterForm(_filePath, FileType.CSV);
            jsonConverterForm.Show();


            Hide();
        }

        private void ConvertXMLButton_Click(object sender, EventArgs e)
        {
            if (IsFilePathExists == false) return;

            ConverterForm jsonConverterForm = new ConverterForm(_filePath, FileType.XML);
            jsonConverterForm.Show();


            Hide();
        }

        private void ConvertToXLSXButton_Click(object sender, EventArgs e)
        {
            if (IsFilePathExists == false) return;

            ConverterForm jsonConverterForm = new ConverterForm(_filePath, FileType.XLSX);
            jsonConverterForm.Show();


            Hide();
        }
    }
}
