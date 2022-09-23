using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    internal class VaccinationModel
    {
        public Guid VaccinationID { get; set; }

        public DateTime VaccineDate { get; set; }

        public Guid VaccineID { get; set; }

        public Guid Patient { get; set; }

        public Guid Doctor { get; set; }

        public Guid Assistant { get; set; }

        public Guid Operator { get; set; }

        public Guid Point { get; set; }


    }
}
