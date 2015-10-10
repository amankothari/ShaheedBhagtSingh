using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TechProject.Data;
using TechProject.Data.Models;
using TechProject.HelperClass;

namespace TechProject.Controllers
{
    [RoutePrefix("api/fileupload")]
    public class FileUploadController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [HttpPost]
        [Route("")]
        public void UploadFile()
        {
            IExcelDataReader excelReader = null;
            Helper helper = new Helper();
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath("~/UploadedFiles/AdminData/ExcelUpload"));

                if (!exists)
                    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/UploadedFiles/AdminData/ExcelUpload"));
                // Get the uploaded image from the Files collection
                var httpPostedFile = HttpContext.Current.Request.Files["StudentFile"];
                if (httpPostedFile != null)
                {
                    var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles/AdminData/ExcelUpload"), httpPostedFile.FileName);
                    httpPostedFile.SaveAs(fileSavePath);
                    FileStream stream = File.Open(fileSavePath, FileMode.Open, FileAccess.Read);

                    if (fileSavePath.Contains(".xls"))
                    {
                        //1. Reading from a binary Excel file ('97-2003 format; *.xls)
                        excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    if (fileSavePath.Contains(".xlsx"))
                    {
                        //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
                        excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    //3. DataSet - The result of each spreadsheet will be created in the result.Tables
                    DataSet result = excelReader.AsDataSet();
                    //4. DataSet - Create column names from first row
                    excelReader.IsFirstRowAsColumnNames = true;
                    // DataSet result = excelReader.AsDataSet();

                    //5. Data Reader methods
                    IList<Student> Studentquery = new List<Student>();
                    while (excelReader.Read())
                    {
                        if (excelReader.Depth > 1)
                        {
                            Student sq = new Student();
                            sq.ApplicantID = excelReader[1].ToString();
                            sq.Name = excelReader[2].ToString();
                            sq.DOB = excelReader[3].ToString();
                            sq.SO = excelReader[4].ToString();
                            sq.Gender = excelReader[5].ToString() == "Male" ? Sex.Male : Sex.Female;
                            sq.Category = helper.Getcategory(excelReader[6].ToString());
                            sq.AdYear = excelReader[7].ToString();
                            sq.Course = _repo.GetCourse(excelReader[8].ToString());
                            sq.Password= excelReader[3].ToString();
                            Studentquery.Add(sq);
                        }
                        //excelReader.GetInt32(0);
                    }
                    _repo.AddStudentList(Studentquery);
                    //6. Free resources (IExcelDataReader is IDisposable)
                    excelReader.Close();
                }


            }
        }
    }
}
