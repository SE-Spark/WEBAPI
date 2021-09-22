using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Cortey", Id = 1 });
            people.Add(new Person { FirstName = "Sam", LastName = "Mun", Id = 2 });
            people.Add(new Person { FirstName = "Peter", LastName = "Lois", Id = 3 });
        }

        [Route("api/People/GetFirstName")]
        [HttpGet]
        public List<String> GetFirstName()
        {
            List<String> output = new List<String>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        [Route("api/People")]
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return people;
        }
        [Route("api/People/{id}")]
        [HttpGet]
        public Person Get(int id)
        {
            return people.Where(x=>x.Id==id).FirstOrDefault();
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
