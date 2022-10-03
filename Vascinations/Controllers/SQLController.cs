using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vascinations.Extensions;
using Vascinations.Models;

namespace Vascinations.Controllers
{
    public class SQLController
    {
private string connectionString;



        public SQLController()
        {
           
        }

        public DataTable RunQueryDt(string query)
        {
            if (connectionString == null)
            {
                connectionString = Controllers.Connection.strConnection();
            }

            DataTable dt = null;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Logs.AddLogError(ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
