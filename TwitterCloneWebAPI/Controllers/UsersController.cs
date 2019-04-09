using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TwitterClone;
using TwitterClonePersistence;

namespace TwitterCloneWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        static TwitterCloneDiskPersistence persistence = new TwitterCloneDiskPersistence();

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return persistence.GetUsers().Select(user => user.Username).ToList();
            
        }

        // GET: api/Users/5
        [HttpGet("{username}", Name = "Get")]
        public string Get(string username)
        {
            StringBuilder sb = new StringBuilder("[");
            var users = persistence.GetUsers();
            var selectedUser = users.Where(user => user.Username == username);
            var tweets = users.Where(user => user.Username == username).Select(user => user.Tweets).ToList();
            foreach (Tweet t in tweets[0])
            {
                sb.Append("{");
                sb.Append("\"" + "username" + "\":");
                sb.Append("\"" + t.User.Username + "\",");
                sb.Append("\"" + "time" + "\":");
                sb.Append("\"" + t.Time + "\",");
                sb.Append("\"" + "content" + "\":");
                sb.Append("\"" + t.Content + "\"");
                sb.Append("},");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
