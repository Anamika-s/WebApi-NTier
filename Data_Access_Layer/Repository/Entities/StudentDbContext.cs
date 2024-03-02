//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace Data_Access_Layer.Repository.Entities;

//public partial class StudentDbContext : DbContext
//{
//    public StudentDbContext()
//    {
//    }

//    public StudentDbContext(DbContextOptions<StudentDbContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Batch> Batches { get; set; }

//    public virtual DbSet<City> Cities { get; set; }

//    public virtual DbSet<Student> Students { get; set; }

//    public virtual DbSet<Student1> Students1 { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=ANAMIKA\\SQLSERVER;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=true");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Batch>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Batch__3213E83FDDA840C2");

//            entity.ToTable("Batch");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Name)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("name");
//        });

//        modelBuilder.Entity<City>(entity =>
//        {
//            entity.Property(e => e.UpdatedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
//        });

//        modelBuilder.Entity<Student>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Student__3213E83F25061484");

//            entity.ToTable("Student");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Address)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("address");
//            entity.Property(e => e.Name)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("name");
//        });

//        modelBuilder.Entity<Student1>(entity =>
//        {
//            entity.ToTable("Students");

//            entity.Property(e => e.Address)
//                .HasMaxLength(10)
//                .IsFixedLength();
//            entity.Property(e => e.Name).HasMaxLength(10);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}


using Data_Access_Layer.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class StudenttDBContext : DbContext
    {
        public StudenttDBContext()
        {

        }
        public StudenttDBContext(DbContextOptions<StudenttDBContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<SpResults> SpResults { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=ANAMIKA\\SQLSERVER;database=StudentDb;integrated security=true;TrustServerCertificate=true")
                    .LogTo(Console.WriteLine,
                         new[] { DbLoggerCategory.Database.Command.Name });
                //.LogTo(Console.WriteLine)
                //  .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDbFunction(typeof(StudenttDBContext).GetMethod(nameof(CountNumberOfStudents), new[] { typeof(int)
    }))
        .HasName("CountNumberOfStudents");
        }

}
