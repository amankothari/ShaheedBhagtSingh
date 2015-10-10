using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TechProject.Data;
using TechProject.Data.Models;

namespace TechProject.Controllers
{
    [RoutePrefix("api/studentlogin")]
    public class StudentLoginController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Getstudentdetail(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetStudentById(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage addloginDetail(Student Student)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetStudentlogin(Student));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPut]
        public HttpResponseMessage updateloginDetail(Student student)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdateStudentProfile(student));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("update")]
        [HttpPost]
        public HttpResponseMessage UploadResults(string id)
        {
            try
            {
                if (HttpContext.Current.Request.Files.AllKeys.Any())
                {
                    bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/"+id));

                    if (!exists)
                        System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/") +id);
                    Student std = new Student();
                    std.ApplicantID = id;
                    foreach (string file in HttpContext.Current.Request.Files)
                    {
                        var filename = HttpContext.Current.Request.Files[file];
                        if (file.ToString() == "10thcert")
                        {
                            filename.SaveAs(Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/") + id, id+"_10thcertificate"+ Path.GetExtension(filename.FileName)));
                            std.cert10thURL = "~/UploadedFiles/StudentData/" + id+"/" + id + "_10thcertificate" + Path.GetExtension(filename.FileName);

                        }
                        if (file.ToString() == "12thcert")
                        {
                            filename.SaveAs(Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/") + id, id + "_12thcertificate" + Path.GetExtension(filename.FileName)));
                            std.cert12thURL = "~/UploadedFiles/StudentData/" + id+"/" + id + "_12thcertificate" + Path.GetExtension(filename.FileName);
                        }
                        if (file.ToString() == "domicilecert")
                        {
                            filename.SaveAs(Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/") + id, id + "_domicilecertificate" + Path.GetExtension(filename.FileName)));
                            std.domicilecertURL = "~/UploadedFiles/StudentData/" + id + "/" + id + "_domicilecertificate" + Path.GetExtension(filename.FileName);
                        }
                        if (file.ToString() == "aadharcrt")
                        {
                            filename.SaveAs(Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles/StudentData/") + id, id + "_aadharcertificate" + Path.GetExtension(filename.FileName)));
                            std.aadharcertURL = "~/UploadedFiles/StudentData/" + id + "/" + id + "_aadharcertificate" + Path.GetExtension(filename.FileName);
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdateStudentProfile(std));
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }


    }
}
