using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    public class VaccineModel
    {
        public Guid VaccineID { get; set; }

        public string VaccineName { get; set; }

        public string Producer { get; set; }

        public int? DoseNumber { get; set; }
        internal static string GetBaseQuery()
        {
            var query = $@" SELECT [VaccineID]
                                  ,[VaccineName]
                                  ,[Producer]
                                  ,[DoseNumber]
                              FROM [dbo].[Vaccine]";

            return query;
        }
        
        public VaccineModel(DataRow dr)
        {
            VaccineID = Tools.Converter.ConvertGeneric<Guid>(dr[0]);
            VaccineName = Tools.Converter.ConvertGeneric<String>(dr[1]);
            Producer = Tools.Converter.ConvertGeneric<String>(dr[2]);
            DoseNumber = Tools.Converter.ConvertGeneric<int>(dr[3]);
        }

    }
}
