using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    
    /// <summary>
    /// This is where I give you all the information about my peeps
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sheffield", LastName = "Turner", Id = 2 });
            people.Add(new Person { FirstName = "Rose", LastName = "Garcia", Id = 3 });
        }


        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <returns>A list of first names</returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<String> GetFirstNames()
        {
           List<String> output = new List<string>();
            
        foreach (var p in people)
            {
            output.Add(p.FirstName);
            }

            return output;
        }

   




        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
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
