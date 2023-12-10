using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayerAPI.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/cat/{id}")]
        public HttpResponseMessage GetUser(int id)
        {
            try
            {
                var data = CategoryServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpPost]
        [Route("api/cat/create")]
        public HttpResponseMessage Create(CategoryDTO data)
        {
            try
            {
                CategoryServices.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
