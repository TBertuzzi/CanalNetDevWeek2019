using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CanalNetDevWeek2019.Models;
using Xamarin.Forms.MultiSelectListView;

namespace CanalNetDevWeek2019.ViewModels
{
    public class MultiSelectListViewViewModel
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

        public MultiSelectObservableCollection<MVP> MVPs { get; }

        public MultiSelectListViewViewModel()
        {
            MVPs = new MultiSelectObservableCollection<MVP>();

            MVP mvp = new MVP
            {
                Nome = "Bertuzzi"
            };

            MVPs.Add(mvp);

            mvp = new MVP
            {
                Nome = "Renato (BOT) Groff"
            };

            MVPs.Add(mvp);

            mvp = new MVP
            {
                Nome = "Thiago Adriano"
            };

            MVPs.Add(mvp);

            mvp = new MVP
            {
                Nome = "Ericson Fonseca"
            };

            MVPs.Add(mvp);

            mvp = new MVP
            {
                Nome = "Milton Camara"
            };

            MVPs.Add(mvp);


        }
    }
}
