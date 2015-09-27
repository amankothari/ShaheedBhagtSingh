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
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Getlogindetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Getlogin(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage addloginDetail(Login login)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Addlogin(login));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage updateloginDetail(Login login)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Updatelogin(login));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage deleteloginDetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.Deletelogin(id));
            }
            catch (Exception)
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
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetAllLogins());
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
