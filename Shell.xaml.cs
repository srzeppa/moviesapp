using System.Linq;
using Windows.UI.Xaml.Controls;
using moviesapp.Common;
using moviesapp.Views;

namespace moviesapp
{
    public sealed partial class Shell : UserControl
    {
        public Shell()
        {
            InitializeComponent();

            var vm = new ShellViewModel();
            vm.MenuItems.Add(new MenuItem { Icon = "", Title = "Welcome", PageType = typeof(WelcomePage) });
            vm.MenuItems.Add(new MenuItem { Icon = "", Title = "Search", PageType = typeof(SearchPage) });
            vm.MenuItems.Add(new MenuItem { Icon = "", Title = "To watch", PageType = typeof(ToWatchPage) });
            vm.MenuItems.Add(new MenuItem { Icon = "", Title = "Page 3", PageType = typeof(Page3) });

            // select the first menu item
            vm.SelectedMenuItem = vm.MenuItems.First();

            ViewModel = vm;
        }

        public ShellViewModel ViewModel { get; private set; }

        public Frame RootFrame => Frame;
    }
}