namespace RestaurantProject
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public List<ProductRecord> Products { get; set; }
        public string Status { get; set; }  

        public Order(int orderId)
        {
            this.OrderId = orderId;
            this.Products = new List<ProductRecord>();
            this.Status = "Pendiente";
        }

        
    }
}
