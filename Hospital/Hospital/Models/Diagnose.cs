using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Diagnose
    {
        [Key]
        public int DiagnoseId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}