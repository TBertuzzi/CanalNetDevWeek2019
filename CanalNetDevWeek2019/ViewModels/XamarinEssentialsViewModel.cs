using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CanalNetDevWeek2019.ViewModels
{
    public class XamarinEssentialsViewModel
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        public double Level => Battery.ChargeLevel;

        public BatteryState State => Battery.State;

        public BatteryPowerSource PowerSource => Battery.PowerSource;

        public EnergySaverStatus EnergySaverStatus => Battery.EnergySaverStatus;

        public string AppPackageName => AppInfo.PackageName;

        public string AppName => AppInfo.Name;

        public string AppVersion => AppInfo.VersionString;

        public string AppBuild => AppInfo.BuildString;

        public Command ShowSettingsUICommand { get; }


        public void OnAppearing()
        {
            Battery.BatteryInfoChanged += OnBatteryInfoChanged;
            Battery.EnergySaverStatusChanged += OnEnergySaverStatusChanged;
        }

        public void OnDisappearing()
        {
            Battery.BatteryInfoChanged -= OnBatteryInfoChanged;
            Battery.EnergySaverStatusChanged -= OnEnergySaverStatusChanged;
        }

        void OnEnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            OnPropertyChanged(nameof(EnergySaverStatus));
        }

        void OnBatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Level));
            OnPropertyChanged(nameof(State));
            OnPropertyChanged(nameof(PowerSource));
        }

        public XamarinEssentialsViewModel()
        {
            ShowSettingsUICommand = new Command(() => AppInfo.ShowSettingsUI());
        }
    }
}
