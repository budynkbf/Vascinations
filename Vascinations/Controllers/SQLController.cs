using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vascinations.Models;

namespace Vascinations.Controllers
{
    public class SQLController
    {

        static List<T> DataRowToGenericList<T>()
        {
            
            var output = new List<T>();
            Type listType = output.GetType().GetGenericArguments()[0];


            return output;
        }

        public List<PersonModel>? personModels { get; set; } 


        public SQLController()
        {
            personModels = DataRowToGenericList<PersonModel>();
        }

    }
}
