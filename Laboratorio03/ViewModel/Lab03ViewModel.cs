using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Laboratorio03.Model;
using Laboratorio03.View;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratorio03.ViewModel
{
    public class Lab03ViewModel : INotifyPropertyChanged
    {
        public Lab03ViewModel()
        {
            InitClass();
            //InitCommands();
        }

        #region Instances
        private ObservableCollection<CdModel> _Catalogo = new ObservableCollection<CdModel>();

        public ObservableCollection<CdModel> Catalogo
        {
            get
            {
                return _Catalogo;
            }
            set
            {
                _Catalogo = value;
                OnPropertyChanged("Catalogo");
            }
        }

        #endregion

        #region Methods

        private async Task InitClass()
        {
            Catalogo = await XMLModel.LoadXMLData();
        }
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
