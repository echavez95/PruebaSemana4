using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaSemana4.Controllers
{
    public class PruebaController : ApiController
    {
        // GET: api/Prueba
        public IHttpActionResult Get()
        {
            return Ok(new int[] { 1, 2, 3, 4, 5 });
        }

        // GET: api/Prueba/5
        public IHttpActionResult Get(int id)
        {
            return Ok(id*2);
        }

        [Route("api/{id}/triple")]
        [HttpGet]
        public IHttpActionResult GetTriple(int id)
        {
            return Ok(id * 3);
        }


        // POST: api/Prueba
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prueba/5
        public void Delete(int id)
        {
        }

    }
}
