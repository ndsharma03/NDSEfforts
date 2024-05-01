using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ListLogger logger;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            logger = new ListLogger();

            
        }
        protected override void OnActivated(EventArgs e)
        {
           
        }
    }
}
