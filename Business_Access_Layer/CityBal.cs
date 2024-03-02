//using Data_Access_Layer;
////using Data_Access_Layer.Repository.Entities;
//using Business_Access_Layer.Models;
//using AutoMapper;
//using Data_Access_Layer.Repository.Entities;

//namespace Business_Access_Layer
//{
//    public class CityBal
//    {
//        private Data_Access_Layer.CityDal _dal;
//        private Mapper _mapper;
//        public CityBal()
//        {
//            _dal = new  Data_Access_Layer.CityDal();
//            //var _config = new MapperConfiguration(cfg => cfg.CreateMap<Student, Business_Access_Layer.Models.StudentModel>().ReverseMap());
//            //_mapper = new Mapper(_config);

        
//        }
        
          
        
//        public List<City> GetCities()
//        {
//            //return_dal.GetStudents();
//            List<City> cities = _dal.GetCities();
//            //List<StudentModel> list = _mapper.Map<List<Student>, List<StudentModel>>(students);
//            return cities;
//        }
//        //public City GetStudent(int id)
//        //{
//        //    //return _dal.GetStudentById(id);
//        //    var student = _dal.GetStudentById(id);
//        //    StudentModel studentModel = _mapper.Map<Student, StudentModel>(student);
//        //    return studentModel;
//        //}
//        public void AddCity(City city)
//        {
//            //Student student1 = _mapper.Map<StudentModel, Student>(student);
//            _dal.AddCity(city);
            

//        }
//    }
//}