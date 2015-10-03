using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Http;

namespace TechProject.Controllers
{
     [RoutePrefix("api/FileUpload")]
    public class FileUploadController : ApiController
    {
        [HttpPost]
        public void UploadFile()
        {
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
               
                // Get the uploaded image from the Files collection
                System.Web.HttpPostedFile httpPostedFile = HttpContext.Current.Request.Files["file"];

                if (httpPostedFile != null)
                {
                    // Validate the uploaded image(optional)
                    byte[] buffer = new byte[httpPostedFile.ContentLength];

                    using (BinaryReader br = new BinaryReader(httpPostedFile.InputStream))
                    {

                        br.Read(buffer, 0, buffer.Length);

                    }
                    XSSFWorkbook hssfwb;
                    //   XSSFWorkbook workbook1;
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        BinaryFormatter binForm = new BinaryFormatter();
                        memStream.Write(buffer, 0, buffer.Length);
                        memStream.Seek(0, SeekOrigin.Begin);
                        hssfwb = new XSSFWorkbook(memStream);
                        string sSheetName = hssfwb.GetSheetName(0);
                        ISheet sheet = hssfwb.GetSheet(sSheetName);
                      
                        IRow rowData;
                        ICell cellData = null;
                        try
                        {
                            for (int iRowIdx = 1; iRowIdx <= sheet.LastRowNum; iRowIdx++)  //  iRowIdx = 0; HeaderRow
                            {
                                rowData = sheet.GetRow(iRowIdx);

                                if (rowData != null)
                                {
                                }
                            }
                            // _UpdateStatus = true;
                        }
                        catch (Exception ex)
                        {
                            //  logger.Error("Error loading URL for " + URL + "\n\n" + ex.Message + "\n\n" + ex.InnerException + "\n\n" + ex.StackTrace);

                        }
                    }

                    var FileUrl = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles"), httpPostedFile.FileName);

                    httpPostedFile.SaveAs(FileUrl);
                }
            }
        }
    }
}
