using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.DTOs
{
    public class NCDDto
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "NCD")]
        [StringLength(255)]
        public string NCDName { get; set; } = string.Empty;

        public IList<NCD_DetailsDto>? NCD_Details { get; set; }
    }
}
