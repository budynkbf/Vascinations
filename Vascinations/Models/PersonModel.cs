using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    internal class PersonModel
    {

        public Guid PersonId { get; set; }

        public string PersonName { get; set; }

        public string PersonSecondName { get; set; }

        public string PersonSecondName2 { get; set; }

        public string Adress { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Role { get; set; }

        public string MedicineID { get; set; }

        public string NIP { get; set; }

        public string Pesel { get; set; }


    }
}
