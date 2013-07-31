using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace LegendControl_DynamicSeries
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.provider.Source = GenerateCollection();
        }

        public List<Data> GenerateData(int i)
        {
            List<Data> data = new List<Data>();
            data.Add(new Data { Category = "Apple", Value = 4 + i});
            data.Add(new Data { Category = "Orange", Value = 15 - i});
            data.Add(new Data { Category = "Lemon", Value = 20 + i * i});
            return data;
        }

        public List<ViewModel> GenerateCollection()
        {
            List<ViewModel> collection = new List<ViewModel>();
            for (int i = 0; i < 5; i++)
            {
                ViewModel vm = new ViewModel();
                vm.Data = GenerateData(i);
                vm.LegendName = "Series " + i;
                collection.Add(vm);
            }
            return collection;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}