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
    [RoutePrefix("api/stquery")]
    public class StudentQueryController : ApiController
    {
        Repository _repo = new Repository(new DataContext());
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Getquerydetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetstudentQuery(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage addqueryDetail(StudentQuery query)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.AddstudentQuery(query));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpPut]
        public HttpResponseMessage updatequeryDetail(StudentQuery query)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.UpdatestudentQuery(query));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("")]
        [HttpDelete]
        public HttpResponseMessage deletequeryDetail(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.DeletestudentQuery(id));
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage allqueryDetail()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetAllstudentQuery());
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
