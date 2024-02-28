using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.Entities
{
    public class NCDDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string NCDName { get; set; } = string.Empty;

        public virtual ICollection<NCD_DetailsDto>? NCD_Details { get; set; }
    }
}
