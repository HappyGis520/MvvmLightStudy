using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmLight001
{
    class DelegateCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteChanged == null)
            {
                throw new NotImplementedException();
            }
            else
           {
               CanExecuteChanged.BeginInvoke(this,<T>Parameter)
               
           }
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
