//using Data_Access_Layer.Repository;
//using Data_Access_Layer.Repository.Entities;
//using Microsoft.EntityFrameworkCore;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


//namespace Data_Access_Layer
//{
//    public class CityUsingAsyncDal
//    {
//        private StudenttDBContext _context;
//        public CityUsingAsyncDal( )
//        {
//                _context = new StudenttDBContext();
//        }
//        public async Task<IEnumerable<City>> GetCities()
//        {
//            //_logger.LogInfo("Inside the GetCompanies method.");

//            var companies = await _context.Cities.ToListAsync();

//            return companies;
//        }

//        //public List<City> GetCities()
//        //{
//        //    return _context.Cities.ToList();
//        //}

//        public async Task<City> GetStudentById(int id)
//        {
//            return await _context.Cities.FirstOrDefaultAsync(x => x.Id == id);
//        }

//        public async Task AddCity(City city)
//        {
//            _context.Cities.Add(city);
//            _context.SaveChangesAsync();
            
//        }
//    }
//}