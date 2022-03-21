using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class PatientMedicament
    {
        [Key]
        public int PatientMedicamentId { get; set; }
        public int MedicamentId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public Medicament Medicament { get; set; }
    }
}