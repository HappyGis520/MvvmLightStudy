using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MvvmLight002_2.Model;

namespace MvvmLight002_2.ViewModel
{
    public class WelcomeViewModel:ViewModelBase
    {
        public WelcomeViewModel()
        {
            _welcome = new WelcomeModel();
        }

        private WelcomeModel _welcome;

        public WelcomeModel Welcome
        {
            get => _welcome;
            set
            {
                _welcome = value;
                RaisePropertyChanged(() => _welcome);
            }
        }
    }
}
