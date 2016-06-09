using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using moviesapp.Common;
using moviesapp.Views;

namespace moviesapp.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var navigationService = CreateNavigationService();
            SimpleIoc.Default.Register(() => navigationService);

            SimpleIoc.Default.Register<IDialogService, DialogService>();

            if (ViewModelBase.IsInDesignModeStatic)
            {
                //SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }

            SimpleIoc.Default.Register<WelcomeViewModel>();
            SimpleIoc.Default.Register<SearchPageViewModel>();
        }

        public WelcomeViewModel Welcome => ServiceLocator.Current.GetInstance<WelcomeViewModel>();
        public SearchPageViewModel Page1 => ServiceLocator.Current.GetInstance<SearchPageViewModel>();

        private INavigationService CreateNavigationService()
        {
            var navigationService = new NavigationServiceUwp();
            navigationService.Configure("SearchPage", typeof(SearchPage));
            // navigationService.Configure("key1", typeof(OtherPage1));
            // navigationService.Configure("key2", typeof(OtherPage2));

            return navigationService;
        }
    }
}