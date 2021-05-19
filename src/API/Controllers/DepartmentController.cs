using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace API.Controllers
{
   
    public class DepartmentController : MainApiController
    {

        //yvar list = new List<string>();
        public DepartmentController()
        {
        }
        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(DepartmentStatic.GetAllDeaprtment());
        }
        [HttpGet("{code}")]
        public IActionResult getA(string code)
        {
            return Ok(DepartmentStatic.GetADepartment(code));
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {
            return Ok(DepartmentStatic.InsertDepartment(department));
        }

        [HttpPut("{code}")]
        public IActionResult update(string code, Department department)
        {
            return Ok(DepartmentStatic.UpdateDepartment(code, department));
        }
        [HttpDelete("{code}")]
        public IActionResult Delete(string code)
        {
            return Ok(DepartmentStatic.DeleteDepartment(code));
        }
    }

    public static class DepartmentStatic
    {

        public static List<Department> AllDepartment { get; set; } = new List<Department>();

        public static Department InsertDepartment(Department department)
        {
            AllDepartment.Add(department);
            return department;
        }
        public static List<Department> GetAllDeaprtment()
        {
            return AllDepartment;
        }

        public static Department GetADepartment(string code)
        {
            return AllDepartment.FirstOrDefault(m => m.Code == code);

        }
        public static Department UpdateDepartment(string code, Department department)
        {
            // Department result = new Department();
            // foreach (var aDepartment in AllDepartment)
            // {
            //     if (code == aDepartment.Code)
            //     {
            //         aDepartment.Name = department.Name;
            //         result = aDepartment;
            //     }
            // }
            // return result;

            var result = AllDepartment.FirstOrDefault(m => m.Code == code);

            result.Name = department.Name;
            return result;

        }
        public static List<Department> DeleteDepartment(string code)
        {
            var department = AllDepartment.FirstOrDefault(m => m.Code == code);
            AllDepartment.Remove(department);
            return AllDepartment;
        }
    }
}
