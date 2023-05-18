namespace LABA1
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSearcKonvert = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ConvertToJSONButton = new System.Windows.Forms.Button();
            this.ConvertToCSVButton = new System.Windows.Forms.Button();
            this.ConvertXMLButton = new System.Windows.Forms.Button();
            this.ConvertToXLSXButton = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearcKonvert
            // 
            this.buttonSearcKonvert.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSearcKonvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearcKonvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearcKonvert.Location = new System.Drawing.Point(236, 11);
            this.buttonSearcKonvert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearcKonvert.Name = "buttonSearcKonvert";
            this.buttonSearcKonvert.Size = new System.Drawing.Size(148, 93);
            this.buttonSearcKonvert.TabIndex = 0;
            this.buttonSearcKonvert.Text = "Выберите файл для ковертации";
            this.buttonSearcKonvert.UseVisualStyleBackColor = false;
            this.buttonSearcKonvert.Click += new System.EventHandler(this.buttonSearcKonvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConvertToJSONButton
            // 
            this.ConvertToJSONButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConvertToJSONButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertToJSONButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertToJSONButton.Location = new System.Drawing.Point(106, 229);
            this.ConvertToJSONButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertToJSONButton.Name = "ConvertToJSONButton";
            this.ConvertToJSONButton.Size = new System.Drawing.Size(134, 62);
            this.ConvertToJSONButton.TabIndex = 1;
            this.ConvertToJSONButton.Text = "Ковертация в JSON";
            this.ConvertToJSONButton.UseVisualStyleBackColor = false;
            this.ConvertToJSONButton.Click += new System.EventHandler(this.ConvertToJSONButton_Click);
            // 
            // ConvertToCSVButton
            // 
            this.ConvertToCSVButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConvertToCSVButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertToCSVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertToCSVButton.Location = new System.Drawing.Point(106, 152);
            this.ConvertToCSVButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertToCSVButton.Name = "ConvertToCSVButton";
            this.ConvertToCSVButton.Size = new System.Drawing.Size(134, 57);
            this.ConvertToCSVButton.TabIndex = 2;
            this.ConvertToCSVButton.Text = "Ковертация в CSV";
            this.ConvertToCSVButton.UseVisualStyleBackColor = false;
            this.ConvertToCSVButton.Click += new System.EventHandler(this.ConvertToCSVButton_Click);
            // 
            // ConvertXMLButton
            // 
            this.ConvertXMLButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConvertXMLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertXMLButton.Location = new System.Drawing.Point(381, 152);
            this.ConvertXMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertXMLButton.Name = "ConvertXMLButton";
            this.ConvertXMLButton.Size = new System.Drawing.Size(134, 57);
            this.ConvertXMLButton.TabIndex = 3;
            this.ConvertXMLButton.Text = "Конвертация в XML";
            this.ConvertXMLButton.UseVisualStyleBackColor = false;
            this.ConvertXMLButton.Click += new System.EventHandler(this.ConvertXMLButton_Click);
            // 
            // ConvertToXLSXButton
            // 
            this.ConvertToXLSXButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConvertToXLSXButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertToXLSXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertToXLSXButton.Location = new System.Drawing.Point(381, 229);
            this.ConvertToXLSXButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertToXLSXButton.Name = "ConvertToXLSXButton";
            this.ConvertToXLSXButton.Size = new System.Drawing.Size(134, 62);
            this.ConvertToXLSXButton.TabIndex = 4;
            this.ConvertToXLSXButton.Text = "Конвертация в XLSX";
            this.ConvertToXLSXButton.UseVisualStyleBackColor = false;
            this.ConvertToXLSXButton.Click += new System.EventHandler(this.ConvertToXLSXButton_Click);
            // 
            // LogText
            // 
            this.LogText.AutoSize = true;
            this.LogText.Location = new System.Drawing.Point(296, 119);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(35, 13);
            this.LogText.TabIndex = 5;
            this.LogText.Text = "status";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(600, 348);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.ConvertToXLSXButton);
            this.Controls.Add(this.ConvertXMLButton);
            this.Controls.Add(this.ConvertToCSVButton);
            this.Controls.Add(this.ConvertToJSONButton);
            this.Controls.Add(this.buttonSearcKonvert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSearcKonvert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ConvertToJSONButton;
        private System.Windows.Forms.Button ConvertToCSVButton;
        private System.Windows.Forms.Button ConvertXMLButton;
        private System.Windows.Forms.Button ConvertToXLSXButton;
        private System.Windows.Forms.Label LogText;
    }
}

