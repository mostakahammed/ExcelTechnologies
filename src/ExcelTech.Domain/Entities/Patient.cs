using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.Entities
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]

        public string PatientName { get; set; } = string.Empty;
        
        [Required]
        [StringLength(5)]
        public string Epilepsy { get; set; } = string.Empty;

        public virtual ICollection<NCD_Details>? NCD_Details { get; set; }
        public virtual ICollection<Allergies_Details>? Allergies_Details { get; set; }
    }
}
