using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using movies.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace moviesapp.ViewModels
{
    public class SearchPageViewModel : ViewModelBase
    { 
        public RelayCommand GoBackCommand { get; private set; }
    }
}