using Lab19_MVVP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab19_MVVP.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private float radius;
        public float Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double length;
        public double Length
        {
            get => length;
            set
            {
                length = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetLengthCommand { get; }
        private void OnGetLengthCommandExecute(object p)
        {
            Length = Ariph.GetLength(Radius);
        }

        private bool CanGetLengthCommandExecute(object p)
        {
            if (Radius == 0)
                return false;
            else
                return true;
        }

        public MainWindowViewModel()
        {
            GetLengthCommand = new RelayCommand(OnGetLengthCommandExecute, CanGetLengthCommandExecute);
        }
    }
}
