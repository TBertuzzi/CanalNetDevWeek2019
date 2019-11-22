using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace CanalNetDevWeek2019
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void ffImageLoading_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanalNetDevWeek2019.Views.FFImageLoading());
        }

        public void localNotifications_Clicked(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("Testando as Notificações", "Agora va ler mais artigos do Bertuzzi no Medium", 1, DateTime.Now.AddSeconds(10));
            Application.Current.MainPage.DisplayAlert("Atenção", "Feche o Aplicativo a notificação vai aparecer em 10 Segundos", "ok");
        }

        public async void fingerprint_Clicked(object sender, EventArgs e)
        {
            var result = await CrossFingerprint.Current.AuthenticateAsync("É você mesmo?");
            if (result.Authenticated)
            {
                await Application.Current.MainPage.DisplayAlert("Atenção", "Autenticado!", "ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Atenção", "Atenção: Este app esta sendo roubado ligue imediatamente para carsystem", "ok");
            }

        }

        public async void MultiSelectListView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanalNetDevWeek2019.Views.MultiSelectListView());
        }

        public async void BehaviorValidationPack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanalNetDevWeek2019.Views.BehaviorValidationPack());
        }

        public async void Converter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanalNetDevWeek2019.Views.ConvertersPack());
        }

        public async void XamarinEssentials_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CanalNetDevWeek2019.Views.XamarinEssentials());
        }
    }
}
