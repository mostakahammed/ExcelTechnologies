using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Domain.DTOs
{
    public class Allergies_DetailsDto
    {
        public int ID { get; set; }

        public int PatientID { get; set; }

        public int? AllergyID { get; set; }
    }
}
