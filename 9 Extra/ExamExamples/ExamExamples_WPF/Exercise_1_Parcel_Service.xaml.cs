using ExamExamples_DAL;
using ExamExamples_Models.Exercise_1;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ExamExamples_WPF
{
    /// <summary>
    /// Interaction logic for Exercise_1_Parcel_Service.xaml
    /// </summary>
    public partial class Exercise_1_Parcel_Service : Window
    {
        // List to store packages
        private List<Package> packageList = new List<Package>();

        // FileOperations instance for reading and logging
        private FileOperations fileOperations = new FileOperations();

        public Exercise_1_Parcel_Service()
        {
            InitializeComponent();
        }

        // Event handler for when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Disable Update button initially
                btnUpdate.IsEnabled = false;

                // Read packages from file and bind to ComboBox
                packageList = fileOperations.ReadParcelService("doc\\parcelService.txt");
                cmbPackages.ItemsSource = packageList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for Two Day radio button
        private void rbTwoDay_Checked(object sender, RoutedEventArgs e)
        {
            lblShipmentType.Content = "Fixed cost";
        }

        // Event handler for Overnight radio button
        private void rbOvernight_Checked(object sender, RoutedEventArgs e)
        {
            lblShipmentType.Content = "Surcharge per kg";
        }

        // Event handler for Calculate button
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input values
                if (double.TryParse(txtWeightInKg.Text, out double weight) &&
                    double.TryParse(txtPricePerKg.Text, out double price) &&
                    double.TryParse(txtShipmentType.Text, out double extra))
                {
                    Package package = null;

                    // Create appropriate package based on selected radio button
                    if (rbTwoDay.IsChecked == true)
                    {
                        package = new TwodayPackage(txtSenderName.Text, txtSenderAddress.Text,
                            txtDestinationName.Text, txtDestinationAddress.Text, weight, price, extra);
                    }
                    else if (rbOvernight.IsChecked == true)
                    {
                        package = new OvernightPackage(txtSenderName.Text, txtSenderAddress.Text,
                            txtDestinationName.Text, txtDestinationAddress.Text, weight, price, extra);
                    }
                    else
                    {
                        throw new Exception("No shipment type selected.");
                    }

                    // Add package to list and update UI
                    packageList.Add(package);
                    ClearTextFields();
                    lblTotalCost.Content = $"Total cost: {package.ShippingCosts():0.00}";
                    cmbPackages.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Weight, Price per kg, and Shipment Type.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                fileOperations.LogErrors(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for Update button
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input values
                if (double.TryParse(txtWeightInKg.Text, out double weight) &&
                    double.TryParse(txtPricePerKg.Text, out double price) &&
                    double.TryParse(txtShipmentType.Text, out double extra))
                {
                    if (cmbPackages.SelectedItem is Package package)
                    {
                        // Update package properties
                        package.DestinationAddress = txtDestinationAddress.Text;
                        package.DestinationName = txtDestinationName.Text;
                        package.SenderAddress = txtSenderAddress.Text;
                        package.SenderName = txtSenderName.Text;
                        package.Weight = weight;
                        package.PricePerKg = price;

                        // Update specific package type properties
                        if (package is TwodayPackage twodayPackage)
                        {
                            twodayPackage.FixedCost = extra;
                        }
                        else if (package is OvernightPackage overnightPackage)
                        {
                            overnightPackage.SurchargePerKg = extra;
                        }

                        // Refresh UI
                        ClearTextFields();
                        cmbPackages.Items.Refresh();
                        cmbPackages.SelectedItem = null;
                        btnCalculate.IsEnabled = true;
                        btnUpdate.IsEnabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for Weight, Price per kg, and Shipment Type.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                fileOperations.LogErrors(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for ComboBox selection change
        private void cmbPackages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCalculate.IsEnabled = false;
            btnUpdate.IsEnabled = true;

            if (cmbPackages.SelectedItem is Package package)
            {
                // Populate text fields with selected package details
                txtDestinationAddress.Text = package.DestinationAddress;
                txtDestinationName.Text = package.DestinationName;
                txtWeightInKg.Text = package.Weight.ToString();
                txtPricePerKg.Text = package.PricePerKg.ToString();
                txtSenderAddress.Text = package.SenderAddress;
                txtSenderName.Text = package.SenderName;

                // Populate Shipment Type based on package type
                if (package is TwodayPackage twodayPackage)
                {
                    txtShipmentType.Text = twodayPackage.FixedCost.ToString();
                    rbTwoDay.IsChecked = true;
                }
                else if (package is OvernightPackage overnightPackage)
                {
                    txtShipmentType.Text = overnightPackage.SurchargePerKg.ToString();
                    rbOvernight.IsChecked = true;
                }
            }
        }

        // Method to clear all text fields
        private void ClearTextFields()
        {
            txtDestinationAddress.Clear();
            txtDestinationName.Clear();
            txtWeightInKg.Clear();
            txtPricePerKg.Clear();
            txtShipmentType.Clear();
            txtSenderAddress.Clear();
            txtSenderName.Clear();
        }
    }
}