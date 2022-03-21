using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Medicament
    {
        [Key]
        public int MedicamentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}