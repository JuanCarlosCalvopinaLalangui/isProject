
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.xmlDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.btnSelectXML = new System.Windows.Forms.Button();
            this.btnXmlToJson = new System.Windows.Forms.Button();
            this.excelDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.btnExcelToJson = new System.Windows.Forms.Button();
            this.btnSavejSON = new System.Windows.Forms.Button();
            this.btnSaveJsonXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xmlDialog
            // 
            this.xmlDialog.FileName = "xml";
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(23, 88);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(180, 20);
            this.txtXml.TabIndex = 0;
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(237, 85);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(103, 23);
            this.btnSelectXML.TabIndex = 1;
            this.btnSelectXML.Text = "Select Xml";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.btnSelectXML_Click);
            // 
            // btnXmlToJson
            // 
            this.btnXmlToJson.Location = new System.Drawing.Point(365, 85);
            this.btnXmlToJson.Name = "btnXmlToJson";
            this.btnXmlToJson.Size = new System.Drawing.Size(106, 23);
            this.btnXmlToJson.TabIndex = 2;
            this.btnXmlToJson.Text = "Convert to JSON";
            this.btnXmlToJson.UseVisualStyleBackColor = true;
            this.btnXmlToJson.Click += new System.EventHandler(this.btnXmlToJson_Click);
            // 
            // excelDialog
            // 
            this.excelDialog.FileName = "excelDialog";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(23, 150);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(180, 20);
            this.txtExcel.TabIndex = 3;
            this.txtExcel.TextChanged += new System.EventHandler(this.txtExcel_TextChanged);
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(237, 146);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(103, 23);
            this.btnSelectExcel.TabIndex = 4;
            this.btnSelectExcel.Text = "Select Excel";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // btnExcelToJson
            // 
            this.btnExcelToJson.Location = new System.Drawing.Point(365, 146);
            this.btnExcelToJson.Name = "btnExcelToJson";
            this.btnExcelToJson.Size = new System.Drawing.Size(106, 23);
            this.btnExcelToJson.TabIndex = 5;
            this.btnExcelToJson.Text = "Convert to JSON";
            this.btnExcelToJson.UseVisualStyleBackColor = true;
            this.btnExcelToJson.Click += new System.EventHandler(this.btnExcelToJson_Click);
            // 
            // btnSavejSON
            // 
            this.btnSavejSON.Location = new System.Drawing.Point(276, 212);
            this.btnSavejSON.Name = "btnSavejSON";
            this.btnSavejSON.Size = new System.Drawing.Size(131, 23);
            this.btnSavejSON.TabIndex = 6;
            this.btnSavejSON.Text = "Save File Json Excel";
            this.btnSavejSON.UseVisualStyleBackColor = true;
            this.btnSavejSON.Click += new System.EventHandler(this.btnSavejSON_Click);
            // 
            // btnSaveJsonXml
            // 
            this.btnSaveJsonXml.Location = new System.Drawing.Point(100, 212);
            this.btnSaveJsonXml.Name = "btnSaveJsonXml";
            this.btnSaveJsonXml.Size = new System.Drawing.Size(119, 23);
            this.btnSaveJsonXml.TabIndex = 7;
            this.btnSaveJsonXml.Text = "Save file xml to json";
            this.btnSaveJsonXml.UseVisualStyleBackColor = true;
            this.btnSaveJsonXml.Click += new System.EventHandler(this.btnSaveJsonXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 258);
            this.Controls.Add(this.btnSaveJsonXml);
            this.Controls.Add(this.btnSavejSON);
            this.Controls.Add(this.btnExcelToJson);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.btnXmlToJson);
            this.Controls.Add(this.btnSelectXML);
            this.Controls.Add(this.txtXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog xmlDialog;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.Button btnXmlToJson;
        private System.Windows.Forms.OpenFileDialog excelDialog;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.Button btnExcelToJson;
        private System.Windows.Forms.Button btnSavejSON;
        private System.Windows.Forms.Button btnSaveJsonXml;
    }
}

