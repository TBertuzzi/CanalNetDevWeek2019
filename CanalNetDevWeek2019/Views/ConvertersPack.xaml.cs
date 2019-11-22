using System;
using System.Collections.Generic;
using CanalNetDevWeek2019.ViewModels;
using Xamarin.Forms;

namespace CanalNetDevWeek2019.Views
{
    public partial class ConvertersPack : ContentPage
    {
        public ConvertersPack()
        {
            InitializeComponent();

            this.BindingContext = new ConvertersViewModel();
        }
    }
}
