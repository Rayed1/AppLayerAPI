using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace AppLayerAPI.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/person/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PersonServices.GetAllPerson();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) 
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/person/{id}")]
        public HttpResponseMessage GetUser(int id)
        {
            try
            {
                var data = PersonServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        [HttpPost]
        [Route("api/person/create")]
        public HttpResponseMessage Create(PersonDTO data)
        {
            try
            {
                PersonServices.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, new  { Msg = "Created" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
