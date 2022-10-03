using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    public class PersonModel
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

        public static  string GetBaseQuery()
        {
            var query = $@" SELECT [PersonId]
                              ,[PersonName]
                              ,[PersonSecondName]
                              ,[PersonSecondName2]
                              ,[Adress]
                              ,[PostCode]
                              ,[City]
                              ,[Role]
                              ,[MedicineID]
                              ,[NIP]
                              ,[Pesel]
                          FROM [dbo].[Person]";
                                    return query;

        }

        public PersonModel(DataRow dr)
        {
            PersonId = Tools.Converter.ConvertGeneric<Guid>(dr[0]);
            PersonSecondName = Tools.Converter.ConvertGeneric<String>(dr[1]);
            PersonSecondName2 = Tools.Converter.ConvertGeneric<String>(dr[2]);
            Adress = Tools.Converter.ConvertGeneric<String>(dr[3]);
            PostCode = Tools.Converter.ConvertGeneric<String>(dr[4]);
            City = Tools.Converter.ConvertGeneric<String>(dr[5]);
            Role = Tools.Converter.ConvertGeneric<String>(dr[6]);
            MedicineID = Tools.Converter.ConvertGeneric<String>(dr[7]);
            NIP = Tools.Converter.ConvertGeneric<String>(dr[8]);
            Pesel = Tools.Converter.ConvertGeneric<String>(dr[9]);
         
        }

      
    }

}
