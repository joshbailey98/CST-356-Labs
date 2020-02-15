using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {       
        [HttpGet]
        public ActionResult<List<Instructor>> Get()
        {
            return Ok(getInstructors());
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var instructor = InMemory.Instructors.FirstOrDefault(i => i.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }

            return Ok(instructor);
        }

        private List<Instructor> getInstructors()
        {
            return InMemory.Instructors;
        }  
    }
}
