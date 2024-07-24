using MDPFinalProject.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDPFinalProject.Views
{
    public partial class AboutPage : ContentPage
    {

        AboutViewModel viewModel = new AboutViewModel();

        public AboutPage()
        {
            InitializeComponent();

            // Bind the ViewModel
            BindingContext = viewModel;
        }

        private void PickerUnitTypes(Object sender, EventArgs e)
        {
            // Load unit types into other pickers
            switch (UnitType.SelectedIndex) 
            {
                // Distance units
                case 0:
                    InputUnits.IsEnabled = true;
                    OutputUnits.IsEnabled = true;

                    // Only include distance measurements
                    InputUnits.ItemsSource = viewModel.Distances;
                    OutputUnits.ItemsSource = viewModel.Distances;
                    break;
                
                // Volume units
                case 1:
                    InputUnits.IsEnabled = true;
                    OutputUnits.IsEnabled = true;
                    break;
                
                // Weight units
                case 2:
                    InputUnits.IsEnabled = true;
                    OutputUnits.IsEnabled = true;
                    break;
            }
        }

        private void OutputUnitChanged(Object sender, EventArgs e) 
        {
            // Display conversions
            switch (UnitType.SelectedIndex)
            {
                case 0:
                    // Display distance conversions
                    ConverterOutput.Text = viewModel.getDistanceConversion(User_Entry.Text, InputUnits.Items[InputUnits.SelectedIndex], OutputUnits.Items[OutputUnits.SelectedIndex]).ToString();
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}