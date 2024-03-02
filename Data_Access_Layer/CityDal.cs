//using Data_Access_Layer.Repository;
//using Data_Access_Layer.Repository.Entities;


//namespace Data_Access_Layer
//{
//    public class CityDal
//    {
//        private StudenttDBContext _context;
//        public CityDal( )
//        {
//                _context = new StudenttDBContext();
//        }
//        public List<City> GetCities()
//        {
//            return _context.Cities.ToList();
//        }

//        //public Student GetStudentById(int id)
//        //{
//        //    return _context.Students.FirstOrDefault(x => x.Id == id);
//        //}

//        public void AddCity(City city)
//        {
//            _context.Cities.Add(city);
//            _context.SaveChanges();
            
//        }
//    }
//}