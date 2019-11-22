using System;
using System.Collections.Generic;
using CanalNetDevWeek2019.ViewModels;
using Xamarin.Forms;

namespace CanalNetDevWeek2019.Views
{
    public partial class MultiSelectListView : ContentPage
    {
        public MultiSelectListView()
        {
            InitializeComponent();

            this.BindingContext = new MultiSelectListViewViewModel();
        }
    }
}
