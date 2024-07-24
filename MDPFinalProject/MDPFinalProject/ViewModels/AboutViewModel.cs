using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MDPFinalProject.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }

        // House unit types
        private string[] _UnitTypeCollection = { "Distance", "Volume", "Weight" };
        public string[] UnitTypeCollection 
        {
            get => _UnitTypeCollection;
            set => _UnitTypeCollection = value; 
        }

        // House distance unit types
        private string[] _Distances = 
        {
            "Centimeters",
            "Decimeters",
            "Meters",
            "Decameters",
            "Hectometers",
            "Kilometers"
        };
        public string[] Distances 
        {
            get => _Distances;
            set => _Distances = value;
        }

        public decimal getDistanceConversion(string number, string inputMeasure, string outputMeasure) 
        {
            try
            {
                decimal userInput = Convert.ToDecimal(number);
                decimal output = 0;

                if (inputMeasure == "Centimeters")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput;
                            break;
                        case "Decimeters":
                            output = userInput / 10;
                            break;
                        case "Meters":
                            output = userInput / 100;
                            break;
                        case "Decameters":
                            output = userInput / 1000;
                            break;
                        case "Hectometers":
                            output = userInput / 10000;
                            break;
                        case "Kilometers":
                            output = userInput / 100000;
                            break;
                    }
                } 
                else if (inputMeasure == "Decimeters") 
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 10;
                            break;
                        case "Decimeters":
                            output = userInput;
                            break;
                        case "Meters":
                            output = userInput / 10;
                            break;
                        case "Decameters":
                            output = userInput / 100;
                            break;
                        case "Hectometers":
                            output = userInput / 1000;
                            break;
                        case "Kilometers":
                            output = userInput / 10000;
                            break;
                    }
                }
                else if (inputMeasure == "Meters")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 100;
                            break;
                        case "Decimeters":
                            output = userInput * 10;
                            break;
                        case "Meters":
                            output = userInput;
                            break;
                        case "Decameters":
                            output = userInput / 10;
                            break;
                        case "Hectometers":
                            output = userInput / 100;
                            break;
                        case "Kilometers":
                            output = userInput / 1000;
                            break;
                    }
                }
                else if (inputMeasure == "Decameters")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 1000;
                            break;
                        case "Decimeters":
                            output = userInput * 100;
                            break;
                        case "Meters":
                            output = userInput * 10;
                            break;
                        case "Decameters":
                            output = userInput;
                            break;
                        case "Hectometers":
                            output = userInput / 10;
                            break;
                        case "Kilometers":
                            output = userInput / 100;
                            break;
                    }
                }
                else if (inputMeasure == "Hectometers")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 10000;
                            break;
                        case "Decimeters":
                            output = userInput * 1000;
                            break;
                        case "Meters":
                            output = userInput * 100;
                            break;
                        case "Decameters":
                            output = userInput * 10;
                            break;
                        case "Hectometers":
                            output = userInput;
                            break;
                        case "Kilometers":
                            output = userInput / 10;
                            break;
                    }
                }
                else if (inputMeasure == "Kilometers")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 100000;
                            break;
                        case "Decimeters":
                            output = userInput * 10000;
                            break;
                        case "Meters":
                            output = userInput * 1000;
                            break;
                        case "Decameters":
                            output = userInput * 100;
                            break;
                        case "Hectometers":
                            output = userInput * 10;
                            break;
                        case "Kilometers":
                            output = userInput;
                            break;
                    }
                }

                return output;
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}