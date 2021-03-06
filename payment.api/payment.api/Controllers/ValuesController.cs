﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace payment.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated =true)]
    [ApiVersion("1.1")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "old1", "old2" };
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public ActionResult<IEnumerable<string>> GetV1_1()
        {
            return new string[] { "new1", "new2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
