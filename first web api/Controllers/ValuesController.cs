using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;





namespace first_web_api.Controllers
{
    public class ValuesController : ApiController
    {
        private string key2;
        private string key1;

        // GET api/values
        public HttpResponseMessage Get()
        {
            var retVal = (key1 = "value1", key2 = "value2");

            return Request.CreateResponse(HttpStatusCode.OK, retVal);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
