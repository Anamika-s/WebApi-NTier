////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using WebApi.Models.DTOs;

//namespace WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [ApiVersion("1.0")]
//    [ApiVersion("2.0")]
//    [Route("api/v{version:apiVersion}/student")]


//    public class CityUsingDTOController : ControllerBase
//    {
//        private Business_Access_Layer.CityBal _bal;
//        public CityUsingDTOController() {
//            _bal = new Business_Access_Layer.CityBal();
//        }

        
//        [HttpGet,MapToApiVersion("1.0")]
//        //[Route("getstudents")]
//        public List<CityDTO> GetCities()
//        {
//            List<City> cities =  _bal.GetCities();
//            List<CityDTO> cities2= new List<CityDTO>();
//            foreach(var city in cities)
//            {
//                CityDTO cityDTO = new CityDTO()
//                {
//                    Id = city.Id,
//                    Name = city.Name,

//                };
//                cities2.Add(cityDTO);
//            }
//            return cities2;
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
//        public void Add(CityDTO cityDto)
//        {
//            var city = new City()
//            {
//                Name = cityDto.Name,
//                UpdatedBy = 100,
//                UpdatedOn = DateTime.Now
//            };
//            _bal.AddCity(city);
//        }
//    }
//}
