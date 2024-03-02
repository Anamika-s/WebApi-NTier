////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    //[ApiVersion("2.0")]
//    [ApiController]

//    //[Route("api/{v:apiVersion}/student")]
//    public class Student1Controller : ControllerBase
//    {
//        private Business_Access_Layer.StudentBal _bal;
//        public Student1Controller() {
//            _bal = new Business_Access_Layer.StudentBal();
//        }

        
//        [HttpGet]
//        public List<string> Get()
//        {
//            List<string> list;
//            return list = new List<string>()
//            {
//                "aa","nbb"
//            };
//        }

//        [HttpGet("{id}")]
//        public StudentModel GetStudent(int id)
//        {
//            return _bal.GetStudent(id);
//        }

//        [HttpPost]
//        public void Add(StudentModel student)
//        {
//            _bal.AddStudent(student);
//        }
//    }
//}
