using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using GalaSoft.MvvmLight;

namespace MvvmLight002.ViewModel
{
    [Bindable]
    public class WelcomeViewModel:ViewModelBase
    {
        public WelcomeViewModel()
        {

        }

        private string welcome;

        public string Welcome
        {
            get => welcome;
            set
            {
                welcome = value;
                RaisePropertyChanged(() => welcome);
            }
        }
    }
}
