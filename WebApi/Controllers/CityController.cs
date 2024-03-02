////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [ApiVersion("1.0")]
//    [ApiVersion("2.0")]
//    [Route("api/v{version:apiVersion}/student")]


//    public class CityController : ControllerBase
//    {
//        private Business_Access_Layer.CityBal _bal;
//        public CityController() {
//            _bal = new Business_Access_Layer.CityBal();
//        }

        
//        [HttpGet,MapToApiVersion("1.0")]
//        //[Route("getstudents")]
//        public List<City> GetCities()
//        {
//            return _bal.GetCities();
//        }


//        [HttpGet, MapToApiVersion("2.0")]
//        //[Route("getnames")]
//        public List<string> GetNames()
//        {
//            return new List<string>() { "aa", "bb", "cc", "dd" };
//        }

//        //[HttpGet("{id}")]
//        //public StudentModel GetStudent(int id)
//        //{
//        //    return _bal.GetStudent(id);
//        //}

//        [HttpPost]
//        public void Add(City city)
//        {
//            _bal.AddCity(city);
//        }
//    }
//}
