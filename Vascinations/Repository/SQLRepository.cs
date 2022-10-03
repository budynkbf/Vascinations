using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vascinations.Controllers;
using Vascinations.Models;

namespace Vascinations.Repository
{
    public class SQLRepository
    {
        private SQLController sqlController;
       
      
        
        public List<PersonModel> GetPersonModelList() {

            var resultList = new List<PersonModel>();
            var query = PersonModel.GetBaseQuery();
            var dtResult = sqlController.RunQueryDt(query);

            if (dtResult == null)
            {
                resultList = new List<PersonModel>();
            }
            else
            {
                foreach (DataRow k in dtResult.Rows)
                    resultList.Add(new PersonModel(k));
            }
            return resultList;
        }




        public List<PointModel> GetPointModelList() { return new List<PointModel>(); }
        public List<VaccinationModel> GetVaccinationModelList() { return new List<VaccinationModel>(); }
        public List<VaccineModel> GetVaccineModelList() { return new List<VaccineModel>(); }


        public SQLRepository()
        {
            sqlController = new SQLController();
        }

    }
}


