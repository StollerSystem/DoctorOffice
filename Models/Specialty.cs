using System.Collections.Generic;
namespace DoctorOffice.Models
{
    public class Specialty
    {
        public Specialty()
        {
            this.SpecialtyDoctors = new HashSet<SpecialtyDoctor>();
        }
        public int SpecialtyId {get; set;}
        public string SpecialtyType {get; set;}
        public string Description {get; set;}
        public virtual ICollection<SpecialtyDoctor> SpecialtyDoctors{get;set;}
    }
} 