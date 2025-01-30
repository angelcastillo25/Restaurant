namespace RestaurantProject
{
   public class Product
   {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
   }
}

