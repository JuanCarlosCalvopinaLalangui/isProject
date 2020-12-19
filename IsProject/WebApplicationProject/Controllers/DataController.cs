using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebApplicationProject.Controllers
{
    public class DataController : ApiController
    {
        // GET: api/Data
        public string Get()
        {
            string filename = @"D:/Enhgenharia_Informatica/3ano_1semestre/IS_Integracao_Sistemas/respaldos_project/materiales project/bin/SHuSH.xlsx";
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
            //return  WindowsFormsApp.Form1.ReadSheet(@"D:\Enhgenharia_Informatica\3ano_1semestre\IS_Integracao_Sistemas\respaldos_project\materiales project\bin\SHuSH.xlsx");
        }

        // GET: api/Data/5
        public string Get(int id)
        {
            string JsonString = @"D:\Enhgenharia_Informatica\3ano_1semestre\IS_Integracao_Sistemas\respaldos_project\materiales project\bin\SHuSH.xlsx.json";
            String JSONtxt = File.ReadAllText(JsonString);
            return JSONtxt; ;
        }

        // POST: api/Data
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Data/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Data/5
        public void Delete(int id)
        {
        }
    }
}
