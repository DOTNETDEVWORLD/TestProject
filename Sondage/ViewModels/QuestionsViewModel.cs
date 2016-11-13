using Sondage.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sondage.ViewModels
{
    public class QuestionsViewModel : ViewModelBase
    {
        public ICommand NavigateToRecapCommand
        {
            get
            {
                return new NavigateToCommand<RecapViewModel>();
            }
        }
    }
}
