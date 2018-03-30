using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MvvmLight002_2.Model
{
    public  class WelcomeModel:ObservableObject
     {
         public WelcomeModel()
         {
             _introduction = "welcom wangjianjun!!!";
         }
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
