using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    internal class VaccineModel
    {
        public Guid VaccineID { get; set; }

        public string VaccineName { get; set; }

        public string Producer { get; set; }

        public int? DoseNumber { get; set; }

    }
}
