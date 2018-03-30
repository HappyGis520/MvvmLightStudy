using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;
using Windows.UI.Xaml.Data;
using GalaSoft.MvvmLight;

namespace MvvmLight002.Model
{
    [Bindable]
    public  class WelcomeModel:ObservableObject
     {
        private string _introduction;

        public string Introduction
        {
            get => _introduction;
            set
            {
                _introduction = value; 
                RaisePropertyChanged(() => Introduction);
            }
        }
        
     }

}
