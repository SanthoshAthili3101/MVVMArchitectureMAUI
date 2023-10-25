
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMArchitecture.ViewModels
{
    public class TestingLabelViewModel : BaseViewModel
    {
        public TestingLabelViewModel()
        {
                
        }

        public Command BackButtonClicked => new Command(GoToBackPage);

        private void GoToBackPage(object obj)
        {
            Shell.Current.GoToAsync("..");
        }
    }
}
