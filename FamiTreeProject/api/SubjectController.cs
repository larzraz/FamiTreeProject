using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamiTreeProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FamiTreeProject.api
{
    [ApiController]
    [Route("api/subject")]
    public class SubjectController : ControllerBase
    {
        private readonly TestClassDataC _db;

        public SubjectController(TestClassDataC db)
        {
            _db = db;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<TestClass> Get()
        {
            return _db.Subjects.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult  Post([FromBody]TestClass subject)
        {
            if (subject == null)
            {
                return BadRequest();
            }
            _db.Subjects.Add(subject);
            _db.SaveChanges();
            return Ok(subject);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
