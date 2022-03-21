using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Visitation
    {
        [Key]
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        public int PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}