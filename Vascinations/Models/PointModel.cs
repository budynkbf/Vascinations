using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Models
{
    internal class PointModel
    {
        public Guid PointID { get; set; }

        public string PointName { get; set; }

        public string Descripion { get; set; }

        public static string GetBaseQuery()
        {
            var query = $@" SELECT [VaccineID]
                                  ,[VaccineName]
                                  ,[Producer]
                                  ,[DoseNumber]
                              FROM [dbo].[Vaccine]";

            return query;
        }

        public PointModel(DataRow dr)
        {
            PointID = Tools.Converter.ConvertGeneric<Guid>(dr[0]);
            PointName = Tools.Converter.ConvertGeneric<String>(dr[1]);
            Descripion = Tools.Converter.ConvertGeneric<String>(dr[2]);
            
        }

    }
}
