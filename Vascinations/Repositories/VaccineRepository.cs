using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vascinations.Models;

namespace Vascinations.Repositories
{
    public class VaccineRepository : InterfaceData

    {
        public void AddData(object data)
        {
            VaccineModel vaccine = new VaccineModel();
            vaccine = (VaccineModel)data;
            //ToDo: try cast bool val execute nonquery
            SqlConnection sqlConnection = new SqlConnection(Controllers.Connection.strConnection());
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $@"Insert into imag.vaccine (VaccineName ,Producer, DoseNumber) values ({vaccine.VaccineName}, {vaccine.Producer}, {vaccine.DoseNumber})";
            cmd.ExecuteNonQuery();

        }

        public void RemoveData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
