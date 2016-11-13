using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sondage.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private ViewModelBase currentView;

        private static NavigationViewModel instance;
        public static NavigationViewModel Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NavigationViewModel();
                }

                return instance;
            }
        }

        private NavigationViewModel()
        {

        }

        public ViewModelBase CurrentView
        {
            get
            {
                return currentView;
            }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public void NavigateTo(ViewModelBase view)
        {
            CurrentView = view;
        }
    }
}
