//using Data_Access_Layer.Repository.Entities;
using Business_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/student")]


    public class StudentController : ControllerBase
    {
        private Business_Access_Layer.StudentBal _bal;
        public StudentController() {
            _bal = new Business_Access_Layer.StudentBal();
        }

        
        [HttpGet,MapToApiVersion("1.0")]
        //[Route("getstudents")]
        public List<StudentModel> GetStudents()
        {
            return _bal.GetStudents();
        }


        [HttpGet, MapToApiVersion("2.0")]
        //[Route("getnames")]
        public List<string> GetNames()
        {
            return new List<string>() { "aa", "bb", "cc", "dd" };
        }

        [HttpGet("{id}")]
        public StudentModel GetStudent(int id)
        {
            return _bal.GetStudent(id);
        }

        [HttpPost]
        public void Add(StudentModel student)
        {
            _bal.AddStudent(student);
        }
    }
}
