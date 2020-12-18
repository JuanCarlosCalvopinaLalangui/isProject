using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectXML_Click(object sender, EventArgs e)
        {
            this.xmlDialog.Title = "Selecionar XML";
            xmlDialog.InitialDirectory = @"C:\Users\";
            xmlDialog.Filter = "XML files (*.xml)|*.xml";
            xmlDialog.CheckFileExists = true;
            xmlDialog.CheckPathExists = true;

            if (xmlDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtXml.Text = xmlDialog.FileName;
            }
        }
        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            this.excelDialog.Title = "Selecionar Excel File";
            excelDialog.InitialDirectory = @"C:\Users\";
            excelDialog.Filter = "Excel Files (*.xlsx)|Excel Files(*.xls)|Excel Files(*.xlsm)|*.xls;*.xlsx;*.xlsm";
            excelDialog.CheckFileExists = true;
            excelDialog.CheckPathExists = true;

            if (excelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtExcel.Text = excelDialog.FileName;
            }
        }

        private void btnXmlToJson_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            String xmlFileName = txtXml.Text;
            doc.Load(xmlFileName);

            string json = JsonConvert.SerializeXmlNode(doc);

            Console.WriteLine(json);


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExcel_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
