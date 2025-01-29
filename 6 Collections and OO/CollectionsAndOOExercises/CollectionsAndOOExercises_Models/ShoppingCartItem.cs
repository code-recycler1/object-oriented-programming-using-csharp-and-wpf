namespace CollectionsAndOOExercises_Models
{
    public class ShoppingCartItem
    {
        // Properties
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        // Read-only property to calculate total price
        public double TotalPrice => Quantity * Price;

        // Constructor with default values
        public ShoppingCartItem() : this(0, "", 0) { }

        // Parameterized constructor
        public ShoppingCartItem(int quantity, string name, double price)
        {
            Quantity = quantity;
            Name = name;
            Price = price;
        }

        // Method to format total price as a string with 2 decimal places
        public string FormattedTotalPrice()
        {
            return $"{TotalPrice:0.00}";
        }

        // Override ToString to provide a textual representation of the item
        public override string ToString()
        {
            return $"{Quantity,3} * {Name,-20} : {FormattedTotalPrice(),6}\n";
        }
    }
}