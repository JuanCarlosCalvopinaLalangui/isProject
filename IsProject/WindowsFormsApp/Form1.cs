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
using Excel = Microsoft.Office.Interop.Excel;


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

        public static List<String> ReadSheet(string filename)
        {
            var dictionary = new Dictionary<String, List<String>>();
            var excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            var excelWorkbook = excelApplication.Workbooks.Open(filename);
            var excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets.get_Item(1);

            Excel.Range range = excelWorksheet.UsedRange;
            List<String> columns = new List<String>();
            List<string> rows = new List<string>();


            for (int i = 1; i <= range.Cells.Columns.Count; i++)
            {

                columns.Add(Convert.ToString(excelWorksheet.Cells[1, i].Value));

                for (int j = 1; j <= range.Cells.Rows.Count; j++)
                {
                    
                    if(Convert.ToString(excelWorksheet.Cells[j + 1, i].Value) == null)
                    {
                        rows.Add(Convert.ToString(excelWorksheet.Cells[j + 1, i].Value));
                    }
                }
             
                dictionary.Add(Convert.ToString(excelWorksheet.Cells[1, i].Value), rows);
            }

            string JSONResult = JsonConvert.SerializeObject(dictionary);

            Console.WriteLine(JSONResult);

            Console.WriteLine("Fin del for");

            //dictionary.Values.
            excelWorkbook.Close();
            excelApplication.Quit();


            ReleaseCOMObjects(range);
            ReleaseCOMObjects(excelWorksheet);
            ReleaseCOMObjects(excelWorkbook);
            ReleaseCOMObjects(excelApplication);

            return columns;
        }

        public static void ReleaseCOMObjects(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                System.Diagnostics.Debug.WriteLine("Exception occured while releasing object" + ex);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnExcelToJson_Click(object sender, EventArgs e)
        {
           List<String> results = ReadSheet(txtExcel.Text);
        }
    }
}
