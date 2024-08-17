using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using TemperatureConverter.Model;   //inherit the Model namespace to link the Model with VM

namespace TemperatureConverter.ViewModels
{
    public class TemperatureViewModel : INotifyPropertyChanged
    {
        //Instantiating the Model class 
        private TemperatureModel model;

        //Constructor
        public TemperatureViewModel()
        {
            model = new TemperatureModel();
            ConvertCommand = new RelayCommand(ConvertTemperatures);
            ResetCommand = new RelayCommand(ResetTemperatures);
        }


        //Relay Command instances
        public ICommand ConvertCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }


        //Properties        
        public double Celsius
        {
            get { return model.Celsius; }   //returns the value from the Model
            set
            {
                if (model.Celsius != value) //If the new value is different from the current value, then 
                {
                    model.Celsius = value;  //it updates the value
                    OnPropertyChanged(nameof(Celsius)); //calls OnPropertyChanged to update it to UI
                    //ConvertTemperatures(null);    //would have triggered a conversion whenever Celsius was changed, and is hence disabled because we want conversion only when Convert button is clicked.
                }
            }
        }

        public double Fahrenheit
        {
            get { return model.Fahrenheit; }
            set
            {
                if (model.Fahrenheit != value)
                {
                    model.Fahrenheit = value;
                    OnPropertyChanged(nameof(Fahrenheit));
                }
            }
        }
        public double Kelvin
        {
            get { return model.Kelvin; }
            set
            {
                if (model.Kelvin != value)
                {
                    model.Kelvin = value;
                    OnPropertyChanged(nameof(Kelvin));
                }
            }
        }       
       
        private void ConvertTemperatures(object obj)
        {
            if(Fahrenheit == 0 && Kelvin == 0)
            {
                model.ConvertFromCelsius();
                Fahrenheit = model.Fahrenheit;
                Kelvin = model.Kelvin;
            }
            
            if(Celsius == 0 && Kelvin == 0)
            {
                model.ConvertFromFahrenheit();
                Celsius = model.Celsius;
                Kelvin = model.Kelvin;
            }

            if(Fahrenheit == 0 && Celsius == 0)
            {
                model.ConvertFromKelvin();
                Celsius = model.Celsius;
                Kelvin = model.Kelvin;
            }

            // Notify UI of property changes
            OnPropertyChanged(nameof(Fahrenheit));
            OnPropertyChanged(nameof(Kelvin));
        }
        
        //private void ConvertTemperatures(object obj)
        //{
        //    Fahrenheit = (Celsius * 9.0 / 5.0) + 32;
        //    Kelvin = Celsius + 273.15;
        //}

        private void ResetTemperatures(object obj)
        {
            model.Reset();
            OnPropertyChanged(nameof(Celsius));
            OnPropertyChanged(nameof(Fahrenheit));
            OnPropertyChanged(nameof(Kelvin));
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }                          
    }

    public class RelayCommand : ICommand
    {
        private Action<object> execute;

        public RelayCommand(Action<object> executeAction)
        {
            execute = executeAction;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
