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
        public string[] Distances = 
        {
            "Centimeters",
            "Meters",
            "Kilometers",
            "Feet",
            "Yards",
            "Miles"
        };

        public double getDistanceConversion(string number, string inputMeasure, string outputMeasure) 
        {
            try
            {
                double userInput = Convert.ToDouble(number);
                double output = 0;

                if (inputMeasure == "Centimeters")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput;
                            break;
                        case "Meters":
                            output = userInput / 100;
                            break;
                        case "Kilometers":
                            output = userInput / 100000;
                            break;
                        case "Feet":
                            output = userInput / 30.48;
                            break;
                        case "Yards":
                            output = userInput / 91.44;
                            break;
                        case "Miles":
                            output = userInput / 160900;
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
                        case "Meters":
                            output = userInput;
                            break;
                        case "Kilometers":
                            output = userInput / 1000;
                            break;
                        case "Feet":
                            output = userInput * 3.281;
                            break;
                        case "Yards":
                            output = userInput * 1.094;
                            break;
                        case "Miles":
                            output = userInput / 1609;
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
                        case "Meters":
                            output = userInput * 1000;
                            break;
                        case "Kilometers":
                            output = userInput;
                            break;
                        case "Feet":
                            output = userInput * 3281;
                            break;
                        case "Yards":
                            output = userInput * 1094;
                            break;
                        case "Miles":
                            output = userInput / 1.609;
                            break;
                    }
                }
                else if (inputMeasure == "Feet")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 30.48;
                            break;
                        case "Meters":
                            output = userInput / 3.281;
                            break;
                        case "Kilometers":
                            output = userInput / 3281;
                            break;
                        case "Feet":
                            output = userInput;
                            break;
                        case "Yards":
                            output = userInput / 3;
                            break;
                        case "Miles":
                            output = userInput / 5280;
                            break;
                    }
                }
                else if (inputMeasure == "Yards")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 91.44;
                            break;
                        case "Meters":
                            output = userInput / 1.094;
                            break;
                        case "Kilometers":
                            output = userInput / 1094;
                            break;
                        case "Feet":
                            output = userInput * 3;
                            break;
                        case "Yards":
                            output = userInput;
                            break;
                        case "Miles":
                            output = userInput / 1760;
                            break;
                    }
                }
                else if (inputMeasure == "Miles")
                {
                    switch (outputMeasure)
                    {
                        case "Centimeters":
                            output = userInput * 160900;
                            break;
                        case "Meters":
                            output = userInput * 1609;
                            break;
                        case "Kilometers":
                            output = userInput * 1.609;
                            break;
                        case "Feet":
                            output = userInput * 5280;
                            break;
                        case "Yards":
                            output = userInput * 1760;
                            break;
                        case "Miles":
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
        // House weight unit types
        public string[] Weights =
        {
            "Kilograms",
            "Pounds",
            "Grams",
            "Ounces"
        };
        public double getWeightConversion(string number, string inputMeasure, string outputMeasure)
        {
            try
            {
                double userInput = Convert.ToDouble(number);
                double output = 0;

                if (inputMeasure == "Kilograms")
                {
                    switch (outputMeasure)
                    {
                        case "Kilograms":
                            output = userInput;
                            break;
                        case "Pounds":
                            output = userInput * 2.20462;
                            break;
                        case "Grams":
                            output = userInput * 1000;
                            break;
                        case "Ounces":
                            output = userInput * 35.274;
                            break;
                    }
                }
                else if (inputMeasure == "Pounds")
                {
                    switch (outputMeasure)
                    {
                        case "Kilograms":
                            output = userInput * 0.453592;
                            break;
                        case "Pounds":
                            output = userInput;
                            break;
                        case "Grams":
                            output = userInput * 453.592;
                            break;
                        case "Ounces":
                            output = userInput * 16;
                            break;
                    }
                }
                else if (inputMeasure == "Grams")
                {
                    switch (outputMeasure)
                    {
                        case "Kilograms":
                            output = userInput / 1000;
                            break;
                        case "Pounds":
                            output = userInput * 0.00220462;
                            break;
                        case "Grams":
                            output = userInput;
                            break;
                        case "Ounces":
                            output = userInput * 0.035274;
                            break;
                    }
                }
                else if (inputMeasure == "Ounces")
                {
                    switch (outputMeasure)
                    {
                        case "Kilograms":
                            output = userInput * 0.0283495;
                            break;
                        case "Pounds":
                            output = userInput * 0.0625;
                            break;
                        case "Grams":
                            output = userInput * 28.3495;
                            break;
                        case "Ounces":
                            output = userInput;
                            break;
                    }
                }

                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}