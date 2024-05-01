/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:AirlineTicketOffice.Main"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using AirlineTicketOffice.Main.Services.Navigation;
using AirlineTicketOffice.Main.ViewModel.Flights;
using AirlineTicketOffice.Main.ViewModel.Tickets;
using AirlineTicketOffice.Model.IRepository;
using AirlineTicketOffice.Repository.Repositories;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using AirlineTicketOffice.Main.Properties;
using System;
using AirlineTicketOffice.Main.Services.Dialog;
using AirlineTicketOffice.Main.ViewModel.Passengers;

namespace AirlineTicketOffice.Main.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            SimpleIoc.Default.Reset();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            
            // Register navigation service (path to 'user control' by key):
            var navigationService = new FrameNavigationService(); 
            navigationService.Configure(Resources.CashierViewKey, new Uri("../View/CashierView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.NewTicketViewKey, new Uri("../View/NewTicketView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.FlightsViewKey, new Uri("../View/FlightsView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.TariffsViewKey, new Uri("../View/TariffsView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.BoughtTicketViewKey, new Uri("../View/BoughtTicketView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.AllPassengerViewKey, new Uri("../View/AllPassengerView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(Resources.NewPassengerViewKey, new Uri("../View/NewPassengerView.xaml", UriKind.RelativeOrAbsolute));

            // Register services and repositories:
            SimpleIoc.Default.Register<IMainNavigationService>(() => navigationService);
            SimpleIoc.Default.Register<IDialogMessage, DialogAbout>();
            SimpleIoc.Default.Register<ITicketRepository, AllTicketsModelRepository>();
            SimpleIoc.Default.Register<ICashierRepository, CashierRepository>();
            SimpleIoc.Default.Register<IPassengerRepository, PassengerModelRepository>();
            SimpleIoc.Default.Register<IBoughtTicketRepository, BoughtTicketRepository>();
            SimpleIoc.Default.Register<IFlightRepository, FlightModelRepository>();
            SimpleIoc.Default.Register<IPlaceInFlightRepository, PlaceInFlightRepository>();
            SimpleIoc.Default.Register<IPlaceInAircraftRepository, PlaceInAircraftRepository>();
            SimpleIoc.Default.Register<ITariffsRepository, TariffsRepository>();
            SimpleIoc.Default.Register<IPdfFileDialogService, PdfFileDialogService>();
            SimpleIoc.Default.Register<IWordFileDialogService, WordFileDialogService>(); 
            SimpleIoc.Default.Register<IXmlDialogService, XmlDialogService>();
            SimpleIoc.Default.Register<INewProcessGo, NewProcessGo>();

            // Register view model:
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NewTicketVM>();
            SimpleIoc.Default.Register<FlightsVM>();
            SimpleIoc.Default.Register<TariffsVM>();
            SimpleIoc.Default.Register<BoughtTicketVM>();
            SimpleIoc.Default.Register<AllPassengersVM>();
            SimpleIoc.Default.Register<NewPassengerVM>();
            SimpleIoc.Default.Register<CashierVM>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public CashierVM CashierVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CashierVM>();
            }
        }


        public  NewTicketVM NewTicketVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NewTicketVM>();
            }
        }

        public AllPassengersVM AllPassengersVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AllPassengersVM>();
            }
        }

        public FlightsVM FlightsVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FlightsVM>();
            }
        }
     
        public TariffsVM TariffsVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TariffsVM>();
            }
        }

        public BoughtTicketVM BoughtTicketVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BoughtTicketVM>();
            }
        }

        public NewPassengerVM NewPassengerVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NewPassengerVM>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}