using Sondage.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sondage.ViewModels
{
    public class RecapViewModel : ViewModelBase
    {

        public ICommand NavigateToQuestionsCommand
        {
            get
            {
                return new NavigateToCommand<QuestionsViewModel>();
            }
        }
    }
}
