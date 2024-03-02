using Data_Access_Layer;
//using Data_Access_Layer.Repository.Entities;
using Business_Access_Layer.Models;
using AutoMapper;
using Data_Access_Layer.Repository.Entities;

namespace Business_Access_Layer
{
    public class StudentBal
    {
        private Data_Access_Layer.StudentDal _dal;
        private Mapper _mapper;
        public StudentBal()
        {
            _dal = new  Data_Access_Layer.StudentDal();
            var _config = new MapperConfiguration(cfg => cfg.CreateMap<Student, Business_Access_Layer.Models.StudentModel>().ReverseMap());
            _mapper = new Mapper(_config);

        
        }
        
          
        
        public List<Business_Access_Layer.Models.StudentModel> GetStudents()
        {
            //return_dal.GetStudents();
            List<Student> students = _dal.GetStudents();
            List<StudentModel> list = _mapper.Map<List<Student>, List<StudentModel>>(students);
            return list;
        }
        public Business_Access_Layer.Models.StudentModel GetStudent(int id)
        {
            //return _dal.GetStudentById(id);
            var student = _dal.GetStudentById(id);
            StudentModel studentModel = _mapper.Map<Student, StudentModel>(student);
            return studentModel;
        }
        public void AddStudent(StudentModel student)
        {
            Student student1 = _mapper.Map<StudentModel, Student>(student);
            _dal.AddStudent(student1);
            

        }
    }
}