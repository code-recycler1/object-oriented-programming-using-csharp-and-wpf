using System.Collections.Generic;
using System.Windows;
using CollectionsAndOOExercises_Models;

namespace CollectionsAndOOExercises_WPF
{
    public partial class Exercise_3_Shopping_Cart : Window
    {
        // List to store shopping cart items
        private List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();

        public Exercise_3_Shopping_Cart()
        {
            InitializeComponent();
        }

        // Event handler for "Show Shopping Cart" button
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            // Clear the shopping cart display
            lblShoppingCart.Content = "";

            double totalPriceShoppingCart = 0;

            // Loop through each item in the shopping cart
            foreach (ShoppingCartItem shoppingCartItem in shoppingCart)
            {
                // Add the item's string representation to the display
                lblShoppingCart.Content += shoppingCartItem.ToString();
                // Accumulate the total price
                totalPriceShoppingCart += shoppingCartItem.TotalPrice;
            }

            // Display the total price of the shopping cart
            lblShoppingCart.Content += $"The total shopping cart is: {totalPriceShoppingCart:0.00}";
        }

        // Event handler for "Add to Shopping Cart" button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (IsInputValid())
            {
                // Create a new ShoppingCartItem and add it to the list
                ShoppingCartItem shoppingCartItem = new ShoppingCartItem(
                    int.Parse(txtQuantity.Text), // Quantity
                    txtName.Text, // Name
                    double.Parse(txtPrice.Text) // Price
                );
                shoppingCart.Add(shoppingCartItem);

                // Clear input fields
                ClearInputFields();

                // Provide feedback to the user
                MessageBox.Show("Item added to the shopping cart!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Show error message if validation fails
                MessageBox.Show("Please ensure all fields are filled correctly:\n" +
                                "- Quantity must be a positive number\n" +
                                "- Name cannot be empty\n" +
                                "- Price must be a positive number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Method to validate user inputs
        private bool IsInputValid()
        {
            return int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0 &&
                   double.TryParse(txtPrice.Text, out double price) && price > 0 &&
                   !string.IsNullOrEmpty(txtName.Text);
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            txtQuantity.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }
    }
}