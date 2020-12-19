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
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using Formatting = Newtonsoft.Json.Formatting;



namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {



        String resultsExcel;
        String pathUserExcel;
        String pathXML;
        String resultXML;



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



            resultXML = JsonConvert.SerializeXmlNode(doc);



            Console.WriteLine(resultXML);




        }
        private void Form1_Load(object sender, EventArgs e)
        {



        }



        private void txtExcel_TextChanged(object sender, EventArgs e)
        {



        }



        public static String ReadSheet(string filename)
        {
            var dictionary = new Dictionary<String, List<String>>();




            var excelApplication = new Excel.Application();
            excelApplication.Visible = false;



            var excelWorkbook = excelApplication.Workbooks.Open(filename);
            var excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets.get_Item(1);



            Excel.Range range = excelWorksheet.UsedRange;
            List<String> columns = new List<String>();
            List<string> rows = new List<string>();
            List<string> id = new List<string>();
            List<string> valores = new List<string>();





            for (int j = 2; j <= range.Cells.Rows.Count; j++)
            {
                id.Add(Convert.ToString(excelWorksheet.Cells[j, 1].Value));
                List<string> header = new List<string>();



                for (int i = 2; i <= range.Cells.Columns.Count; i++)
                {



                    if (Convert.ToString(excelWorksheet.Cells[j, i].Value) == null)
                    {
                        i = range.Cells.Columns.Count;
                    }



                    string sub = $"{Convert.ToString(excelWorksheet.Cells[1, i].Value)}\" : \"{Convert.ToString(excelWorksheet.Cells[j, i].Value)}";
                    header.Add(sub);



                }
                // if (dictionary.ContainsKey(Convert.ToString(excelWorksheet.Cells[j, 1].Value)) == true) { 



                dictionary.Add(Convert.ToString(excelWorksheet.Cells[j, 1].Value), header);



                //}
            }



            string JSONResult = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
            string json2 = JSONResult.Replace("\\", String.Empty);
            string json3 = json2.Replace("[", "{");
            string json4 = json3.Replace("]", "}");



            Console.WriteLine(json4);



            excelWorkbook.Close();
            excelApplication.Quit();




            ReleaseCOMObjects(range);
            ReleaseCOMObjects(excelWorksheet);
            ReleaseCOMObjects(excelWorkbook);
            ReleaseCOMObjects(excelApplication);



            return json4;
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
            resultsExcel = ReadSheet(txtExcel.Text);
        }



        private void btnSavejSON_Click(object sender, EventArgs e)
        {
            //string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            pathUserExcel = txtExcel.Text + ".json";
            //string pathDownload = Path.Combine(pathUser, "Documents\\excel.json");



            Console.WriteLine(pathUserExcel);



            using (StreamWriter file = new StreamWriter(pathUserExcel, false))
            {
                file.WriteLine(resultsExcel); //se agrega información al documento



                file.Close();
            }
        }



        private void btnSaveJsonXml_Click(object sender, EventArgs e)
        {
            //string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            pathXML = txtXml.Text + ".json";
            //string pathDownload = Path.Combine(pathUser, "Documents\\excel.json");



            Console.WriteLine(pathXML);



            using (StreamWriter file = new StreamWriter(pathXML, false))
            {
                file.WriteLine(resultsExcel); //se agrega información al documento



                file.Close();
            }
        }
    }
}