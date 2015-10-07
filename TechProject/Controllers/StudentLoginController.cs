using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            catch (Exception)
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
    }
}
