namespace RestauranteProject
{
    abstract class Order
{
    public int OrderId { get; set; }
    public List<Product> Products { get; set; }
    public string Status { get; set; }

    public Order(int orderId)
    {
        OrderId = orderId;
        Products = new List<Product>();
        Status = "Pendiente";
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }
}
}
