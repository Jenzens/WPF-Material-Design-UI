using Caliburn.Micro;
using System.Windows;
using WPFMenu.ViewModels;

namespace WPFMenu
{
    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        // override OnStartup för att visa ShellViewModel
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
