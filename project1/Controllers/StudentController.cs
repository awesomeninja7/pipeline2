using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project1.Models;
using System.Collections.Immutable;

namespace project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        private List<User> users = new List<User>
        {
            new User { UserId = 1, UserEmail = "student1@example.com", Username = "Student 1" },
            new User { UserId = 2, UserEmail = "student2@example.com", Username = "Student 2" },
            new User { UserId = 3, UserEmail = "student3@example.com", Username = "Student 3" }
        };
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            
            return users;
        }

    }
}
