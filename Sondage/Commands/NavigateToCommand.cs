using Sondage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sondage.Commands
{
    public class NavigateToCommand<T> : ICommand where T : ViewModelBase, new()
    {      
        public event EventHandler CanExecuteChanged;          

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var navigation = NavigationViewModel.Instance;

            var cible = new T();
            navigation.NavigateTo(cible);
            DoSomethingWithParameter(cible, parameter);          
        }      

        public virtual void DoSomethingWithParameter(ViewModelBase cible, object parameter)
        {

        }
    }
}
