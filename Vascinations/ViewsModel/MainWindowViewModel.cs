using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vascinations.Controllers;
using Vascinations.Models;
using Vascinations.Repository;

namespace Vascinations.ViewsModel
{
    public class MainWindowViewModel : PrismImpl
    {
        #region Privates

        private List<PersonModel> personModelsList;
        private List<PointModel> pointModelsList;
        private List<VaccinationModel> vaccinationModelsList;
        private List<VaccineModel> vaccineModelsList;

        private SQLController sQLController;
        private SQLRepository sQLRepository;



        #endregion Privates
        #region Publics

        public ICommand TestData { get; set; }

        public List<PersonModel> PersonModelsList
        {
            get { return personModelsList; }
            set
            {
                personModelsList = value;
                OnPropertyChanged();
            }
        }

        #endregion Publics
        #region Constructor
      public  MainWindowViewModel()
        {
            TestData = new DelegateCommand(TestDataAction);
            sQLController = new SQLController();
            sQLRepository = new SQLRepository();    
            

        }

        private void TestDataAction()
        {
            PersonModelsList = sQLRepository.GetPersonModelList();


        }
        #endregion Constructor

    }
}
