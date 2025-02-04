
namespace RestaurantProject
{
    public class Invoice
    {
        public string ClienteNombre { get; set; }
        public int ClienteID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Order Order { get; set; }

        public Invoice(Client cliente, decimal amount, Order order)
        {
            this.ClienteNombre = cliente.Name;
            this.ClienteID = cliente.Id;
            this.Amount = amount;
            this.Date = DateTime.Now;
            this.Order = order;
        }

        public decimal CalculateTotal()
        {

            decimal total = 0;
            foreach (var product in Order.Products)
            {
                total += product.Product.Price*product.Quantity;
            }
            return total;
        }

        public void ShowInvoice()
        {
            Console.WriteLine("----- FACTURA -----");
            Console.WriteLine($"Cliente: {this.ClienteNombre} (ID: {this.ClienteID})");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Productos:");
            foreach (var product in this.Order.Products)
            {
                Console.WriteLine($"- {product.Product.Name} x{product.Quantity}: {product.Product.Price*product.Quantity:C}");
            }
            Console.WriteLine($"Total: {this.CalculateTotal():C}");
            Console.WriteLine($"Monto con el que se paga: {this.Amount:C}");
            Console.WriteLine($"Fecha: {Date}");
            Console.WriteLine("-------------------");
        }
    }
}
