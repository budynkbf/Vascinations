using NLog;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Vascinations.Controllers;
using Vascinations.Models;
using Vascinations.Repository;

namespace Vascinations.ViewsModel
{
    public class MainWindowViewModel : PrismImpl
    {
        #region Privates

        private string _activeTab = "Osoby";


        private List<PersonModel> personModelsList;
        private List<PointModel> pointModelsList;
        private List<VaccinationModel> vaccinationModelsList;
        private List<VaccineModel> vaccineModelsList;

        private SQLController sQLController;
        private SQLRepository sQLRepository;

        private TabControl tabsControl; 

        #endregion Privates
        #region Publics


        //public TabControl TabsControl
        //{
        //    get { return tabsControl; }
        //    set { tabsControl = value;
        //        OnPropertyChanged();  } 
        //}

        public string ActiveTab
        {
            get { return _activeTab; }
            set
            {
                _activeTab = value;
                OnPropertyChanged();
            }
       }


        public ICommand TestData { get; set; }

        public ICommand AddData { get; set; }

        public ICommand MarkActiveTab { get; set; }

        public List<PersonModel> PersonModelsList
        {
            get { return personModelsList; }
            set
            {
                personModelsList = value;
                OnPropertyChanged();
            }
        }

        public List<PointModel> PointModelList
        {
            get { return pointModelsList; }
            set
            {
                pointModelsList = value;
                OnPropertyChanged();
            }
        }
        public List<VaccinationModel> VaccinationModelList
        {
            get { return vaccinationModelsList; }
            set
            {
                vaccinationModelsList = value;
                OnPropertyChanged();
            }
        }

        public List<VaccineModel> VaccineModelsList
        {
            get { return vaccineModelsList; }
            set
            {
                vaccineModelsList = value;
                OnPropertyChanged();
            }
        }

        #endregion Publics

        #region Constructor

        public MainWindowViewModel()
        {
            TestData = new DelegateCommand(TestDataAction);
            AddData = new DelegateCommand<object>(AddDataAction);
            MarkActiveTab = new DelegateCommand<object>(MarkActiveTabAction);

            sQLController = new SQLController();
            sQLRepository = new SQLRepository();
            tabsControl = new TabControl();
            tabsControl.SelectedIndex = 2;
            
        }

        private void MarkActiveTabAction(object obj)
        {
            _activeTab = obj.ToString();

        }

        private void AddDataAction(object obj)
        {
            MessageBox.Show("Add data " + ActiveTab);
            
            Window wn = new Window();
            //ToDo otieranie dodawania zależnie od aktualnego tabu
            wn.DataContext = ActiveTab;
            wn.Show();
        }

        private void TestDataAction()
        {

             Logger _logger = LogManager.GetCurrentClassLogger();
            _logger.Info("Main Thread Started"); 


            PersonModelsList = sQLRepository.GetPersonModelList();
            PointModelList = sQLRepository.GetPointModelList();
            VaccinationModelList = sQLRepository.GetVaccinationModelList();
            VaccineModelsList = sQLRepository.GetVaccineModelList();

        }
        #endregion Constructor

    }
}
