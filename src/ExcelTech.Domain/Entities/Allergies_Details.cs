using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.Entities
{
    public class Allergies_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Allergy")]
        public int? AllergyID { get; set; }

        public Allergy? Allergy { get; set; }
    }
}
