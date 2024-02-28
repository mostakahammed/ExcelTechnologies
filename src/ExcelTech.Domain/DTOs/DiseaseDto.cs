using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcelTech.Domain.DTOs
{
    public class DiseaseDto
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Disease Name")]
        [StringLength(50)]
        public string DiseaseName { get; set; } = string.Empty;
    }
}
