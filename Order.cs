namespace RestaurantProject
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }
        public string Status { get; set; }  

        public Order(int orderId)
        {
            this.OrderId = orderId;
            this.Products = new List<Product>();
            this.Status = "Pendiente";
        }

        
    }
}
