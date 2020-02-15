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
    public class StudentController : ControllerBase
    {       
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var student = InMemory.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        private List<Student> getStudents()
        {
            return InMemory.Students;
        }  
    }
}
