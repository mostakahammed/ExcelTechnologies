using ExcelTech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcelTech.Domain.DTOs
{
    public class PatientDto
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Patient Name")]
        [StringLength(50)]
        public string PatientName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Epilepsy")]
        [StringLength(5)]
        public string Epilepsy { get; set; } = string.Empty;

        public IList<NCD_DetailsDto>? NCD_Details { get; set; }
        public IList<Allergies_DetailsDto>? Allergies_Details { get; set; }
    }
}
