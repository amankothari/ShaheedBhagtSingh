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
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage GetadminDetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetAdmin(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage addadminDetail(Admin admin)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.AddAdmin(admin));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage updateadminDetail(Admin admin)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdateAdmin(admin));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage deleteadminDetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.DeleteAdmin(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage alladminDetail()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetAllAdmin());
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
