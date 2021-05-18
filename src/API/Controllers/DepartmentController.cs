using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class DepartmentController : ControllerBase
    {

        //var list = new List<string>();
        public DepartmentController()
        {
        }
        [HttpGet]
        public IActionResult getAll()
        {
            return Ok("get all students");
        }
        [HttpGet("{code}")]
        public IActionResult getA(string code)
        {
            return Ok($"get a student {code}");
        }
        [HttpPost]
        public IActionResult Add(string code)
        {
            return Ok("insert a new dept");
        }

        [HttpPut("{id}")]
        public IActionResult update(string id)
        {
            return Ok("updated new dept" + id);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok("Deleted new dept" + id);
        }
    }
}
