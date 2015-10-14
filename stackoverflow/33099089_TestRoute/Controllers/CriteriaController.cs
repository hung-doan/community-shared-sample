using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestRoute.Models;

namespace TestRoute.Controllers
{
    public class CriteriaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Hello world!");
        }
        [HttpGet]
        public IHttpActionResult Get(int id, [FromUri]Criteria criteria)
        {
            return Ok(criteria);
        }
    }
}
