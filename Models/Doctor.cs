using System.Collections.Generic;
namespace DoctorOffice.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.PatientDoctors = new HashSet<PatientDoctor>();
            this.SpecialtyDoctors = new HashSet<SpecialtyDoctor>();
        }
        public int DoctorId {get; set;} 
        public string Name {get;set;}
        public virtual ICollection<PatientDoctor> PatientDoctors{get; set;}
        public virtual ICollection<SpecialtyDoctor> SpecialtyDoctors{get; set;}
    }
}