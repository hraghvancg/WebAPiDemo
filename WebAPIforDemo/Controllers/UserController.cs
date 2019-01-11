using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    public class UserController : ApiController
    {
        private User[] users = new User[]
   {
        new User { id = 1, name = "Sachin Tendulkar", email = "email1@mail.com", phone = "01111111", role = 1},
        new User { id = 2, name = "MS Dhoni", email = "email2@mail.com", phone = "01111111", role = 1},
        new User { id = 3, name = "Virat Kohli", email = "email3@mail.com", phone = "01111111", role = 1},
        new User { id = 4, name = "Bhuvneshwar Kumar", email = "email4@mail.com", phone = "01111111", role = 2},
        new User { id = 5, name = "Jasprit Bumrah", email = "email5@mail.com", phone = "01111111", role = 3},
        new User { id = 6, name = "AB De Villiers", email = "email6@mail.com", phone = "01111111", role = 3},
        new User { id = 7, name = "Chris Gayle", email = "email7@mail.com", phone = "01111111", role = 3},
        new User { id = 7, name = "Brian Lara", email = "email8@mail.com", phone = "01111111", role = 3}
   };
        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }
        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

       /* // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
