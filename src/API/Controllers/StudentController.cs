
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace API.Controllers
{

    public class StudentController : MainApiController
    {

        public StudentController()
        {

        }
        [HttpGet]
        public IActionResult getAll([FromQuery] string rollnumber, [FromQuery] string nickname)
        {
            return Ok(AllStudentStatic.getAllStudent());
        }

        [HttpGet("{email}")]
        public IActionResult GetAStudent(string email)
        {
            return Ok(AllStudentStatic.getSingleStudent(email));
        }
        [HttpPost]
        public IActionResult InsertStundet(Student student)
        {
            return Ok(AllStudentStatic.InsertStundet(student));
        }
        [HttpPut("{email}")]
        public IActionResult UpdateStundet(string email, Student student)
        {
            return Ok(AllStudentStatic.InsertStundet(student));
        }
        [HttpDelete("{email}")]
        public IActionResult DeleteStundet(string email)
        {
            return Ok(AllStudentStatic.DeleteStudent(email));
        }
    }
    public static class AllStudentStatic
    {
        public static List<Student> Allstudents { get; set; } = new List<Student>();

        public static List<Student> getAllStudent()
        {
            return Allstudents;
        }
        public static Student getSingleStudent(string email)
        {
            return Allstudents.FirstOrDefault(m => m.email == email);

        }
        public static Student InsertStundet(Student Student)
        {
            Allstudents.Add(Student);
            return Student;

        }
        public static Student UpdateStudent(string email, Student student)
        {
            //var newobj = new Student();
            var resultindb = Allstudents.FirstOrDefault(m => m.email == email);
            resultindb.name = student.name;
            return resultindb;
        }
        public static List<Student> DeleteStudent(string email)
        {
            var resultindb = Allstudents.FirstOrDefault(m => m.email == email);
            Allstudents.Remove(resultindb);
            return Allstudents;
        }

    }
}
