using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data_Access_Layer
{

    public class StudentDal
    {
        private StudenttDBContext _context;
        public StudentDal( )
        {
                _context = new StudenttDBContext();
        }
        public List<Student> GetStudents()
        {
            //return _context.Students.FromSql($"exec dbo.GetStudents").ToList();
            //_context.Database.ExecuteSql($"GetStudents");
            var list =  _context.SpResults.FromSqlInterpolated($"GetStudents").ToList();
            List<Student> lists = new List<Student>();
            foreach(var obj in list)
            {
                var student = new Student()
                { Id = obj.Id, Name = obj.Name };
                lists.Add(student);

            }
            return lists;

        }

        public object CountNumberOfStudents()
        {
            var query1 = from b in _context.Students
                         //where context.ActivePostCountForBlog(b.BlogId) > 1
                         select b;
        }
    
    public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public void AddStudent(Student student)
        {
            //_context.Database.Log = message => File.AppendText("C:\\mylog.txt").WriteLine(message);
            using var transaction = _context.Database.BeginTransaction();
            try
                {
                    _context.Students.Add(student);
                    var ss = _context.Students.FirstOrDefault(x => x.Id == student.Id);
                    _context.SaveChanges();

                    transaction.Commit();
                }catch(Exception ex)
                {
                transaction.Rollback();
                }
            
            
        }
    }
}