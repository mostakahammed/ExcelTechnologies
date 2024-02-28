using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.DTOs
{
    public class AllergyDto
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Allergy")]
        [StringLength(255)]
        public string AllergyName { get; set; } = string.Empty;

        public IList<Allergies_DetailsDto>? Allergies_Details { get; set; }
    }
}
