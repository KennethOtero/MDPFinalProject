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
                    // Only include volume measurements
                    InputUnits.ItemsSource = viewModel.Volumes ;
                    OutputUnits.ItemsSource = viewModel.Volumes;
                    break;
                
                // Weight units
                case 2:
                    InputUnits.IsEnabled = true;
                    OutputUnits.IsEnabled = true;
                    // Only include weight measurements
                    InputUnits.ItemsSource = viewModel.Weights;
                    OutputUnits.ItemsSource = viewModel.Weights;
                    break;
            }
        }

        private void UnitChanged(Object sender, EventArgs e) 
        {
            //This checks that data is not null and prevents exceptions from occurring
            if (UnitType.SelectedIndex != -1 && !string.IsNullOrEmpty(User_Entry.Text) && InputUnits.SelectedIndex != -1 && OutputUnits.SelectedIndex != -1)
            {
                // Display conversions
                switch (UnitType.SelectedIndex)
                {
                    case 0:
                        // Display distance conversions
                        ConverterOutput.Text = viewModel.getDistanceConversion(User_Entry.Text, InputUnits.Items[InputUnits.SelectedIndex], OutputUnits.Items[OutputUnits.SelectedIndex]).ToString();
                        break;
                    case 1:
                        // Volume Conversions
                        ConverterOutput.Text = viewModel.getVolumeConversion(User_Entry.Text, InputUnits.Items[InputUnits.SelectedIndex], OutputUnits.Items[OutputUnits.SelectedIndex]).ToString();
                        break;
                    case 2:
                        // Weight Conversions
                        ConverterOutput.Text = viewModel.getWeightConversion(User_Entry.Text, InputUnits.Items[InputUnits.SelectedIndex], OutputUnits.Items[OutputUnits.SelectedIndex]).ToString();
                        break;
                }
            }
        }
    }
}