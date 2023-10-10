namespace lab5
{
    internal class Goods : BaseInform
    {
        public string Category { get; set; }
        public int StockQuantity { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Category: {Category}, Stock Quantity: {StockQuantity}, Manufacturer: {Manufacturer}";
        }
    }
}