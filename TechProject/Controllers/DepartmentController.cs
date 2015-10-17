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
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage GetallDepartments()
        {
            try
            {
                return Request.CreateResponse( HttpStatusCode.OK,_repo.GetallDepartments());
            }
            catch (Exception)
            {

                throw;
            }


        }
        [Route("getbyid")]
        [HttpGet]
        public HttpResponseMessage GetDepartment(int DepartmentId)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetDepartment(DepartmentId));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpPost]
        public HttpResponseMessage AddDepartment(Department DepartmentObj)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Created, _repo.AddDepartment(DepartmentObj));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage UpdateDepartment(Department DepartmentObj)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdateDepartment(DepartmentObj));

            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(int DepartmentId)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.DeleteDepartment(DepartmentId));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
