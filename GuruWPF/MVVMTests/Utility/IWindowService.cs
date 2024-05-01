using MVVMTests.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTests.ViewModel
{
    interface IWindowService
    {
        void OpenWindow(ViewModelBase viewModel);
    }

    class WindowService : IWindowService
    {
        public void OpenWindow(ViewModelBase viewModel)
        {
            ContainerWindow window = new ContainerWindow();
            window.DataContext = viewModel;
            viewModel.IsOpenedInWindow = true;
            window.Show();

        }
    }
}
