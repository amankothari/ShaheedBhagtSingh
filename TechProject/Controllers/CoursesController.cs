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
    [RoutePrefix("api/course")]
    public class CoursesController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Getcoursedetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Getcourse(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage addloginDetail(Courses course)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Addcourse(course));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage updatecourseDetail(Courses course)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Updatecourse(course));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage deletecourseDetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Deletecourse(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage allcourseDetail()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetcourseList());
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
