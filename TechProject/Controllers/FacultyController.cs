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
    [RoutePrefix("api/faculty")]
    public class FacultyController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage GetallFaculties()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetAllFaculties());
            }
            catch (Exception)
            {

                throw;
            }


        }
        [Route("getbyid")]
        [HttpGet]
        public HttpResponseMessage GetFaculty(int FacultyId)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetFaculty(FacultyId));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpPost]
        public HttpResponseMessage AddDepartment(Faculty FacultyObj)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Created, _repo.AddFaculty(FacultyObj));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage UpdateDepartment(Faculty FacultyObj)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdateFaculty(FacultyObj));

            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(int FacultyId)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.DeleteFaculty(FacultyId));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
