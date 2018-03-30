using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;
using GalaSoft.MvvmLight;

namespace MvvmLight002.Model
{
     public  class WelcomeModel:ObservableObject
     {
        private string introduction;

        public string Introduction
        {
            get => introduction;
            set
            {
                introduction = value; 
                RaisePropertyChanged(() => Introduction);
            }
        }
        
     }

    public class  wjj
    {
         public String abc;

        public string Getname( [CallerMemberName]string abc="")
        {
            return abc+abc;

        }

    }
}
