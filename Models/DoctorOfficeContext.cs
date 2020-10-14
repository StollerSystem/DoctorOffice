using Microsoft.EntityFrameworkCore;
namespace DoctorOffice.Models
{
    public class DoctorOfficeContext : DbContext
    {
         public  DbSet<Patient> Patient { get; set; }
         public  DbSet<Doctor> Doctors { get; set; }
         public  DbSet<Specialty> Specialties { get; set; } 
         public  DbSet<PatientDoctor> PatientDoctors { get; set; }
         public  DbSet<SpecialtyDoctor> SpecialtyDoctors { get; set; }

        public DoctorOfficeContext(DbContextOptions options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}


