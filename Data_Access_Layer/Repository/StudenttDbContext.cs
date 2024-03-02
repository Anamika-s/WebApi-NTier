//using Data_Access_Layer.Repository.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data_Access_Layer.Repository
//{
//    public class StudenttDBContext :DbContext
//    {
//        public StudenttDBContext()
//        {

//        }
//        public StudenttDBContext(DbContextOptions<StudenttDBContext> options)
//            : base(options) { }

//        public DbSet<Student> Students { get; set; }
//        public DbSet<SpResults> SpResults { get; set; }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer("server=ANAMIKA\\SQLSERVER;database=StudentDb;integrated security=true;TrustServerCertificate=true")
//                    .LogTo(Console.WriteLine,
//                         new[] { DbLoggerCategory.Database.Command.Name });
//                //.LogTo(Console.WriteLine)
//                //  .EnableSensitiveDataLogging();
//            }
//        }



//    }
//}
