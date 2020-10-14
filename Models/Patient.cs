using System;
using System.Collections.Generic;

namespace DoctorOffice.Models
{
    public class Patient
    {
        public Patient()
        {
            this.PatientDoctors = new HashSet<PatientDoctor>();
        }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public virtual ICollection<PatientDoctor> PatientDoctors {get;set;}


    }
}