//using Data_Access_Layer;
////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using AutoMapper;
//using Data_Access_Layer.Repository.Entities;

//namespace Business_Access_Layer
//{
//    public class CityUsingAsyncBal
//    {
//        private Data_Access_Layer.CityUsingAsyncDal _dal;
//        private Mapper _mapper;
//        public CityUsingAsyncBal()
//        {
//            _dal = new  Data_Access_Layer.CityUsingAsyncDal();
//            //var _config = new MapperConfiguration(cfg => cfg.CreateMap<Student, Business_Access_Layer.Models.StudentModel>().ReverseMap());
//            //_mapper = new Mapper(_config);

        
//        }
        
          
        
//        public async Task<List<City>> GetCities()
//        {
//            //return_dal.GetStudents();
//            List<City> cities = (List<City>)await _dal.GetCities();
//            //List<StudentModel> list = _mapper.Map<List<Student>, List<StudentModel>>(students);
//            return cities;
//        }
//        public async Task<City> GetStudent(int id)
//        {
//            //return _dal.GetStudentById(id);
//            var city = await _dal.GetStudentById(id);
//            return city;
//        }
//        public async Task AddCity(City city)
//        {
//             await _dal.AddCity(city);
            

//        }
//    }
//}