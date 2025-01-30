
namespace RestaurantProject
{
    public class Invoice
    {
        public string ClienteNombre { get; private set; }
        public int ClienteID { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime Fecha { get; private set; }
        public Order Order { get; private set; }

        public Invoice(Client cliente, decimal amount, Order order)
        {
            ClienteNombre = cliente.Name;
            ClienteID = cliente.Id;
            Amount = amount;
            Fecha = DateTime.Now;
            Order = order;
        }

        public decimal CalculateTotal()
        {

            decimal total = 0;
            foreach (var product in Order.Products)
            {
                total += product.Price;
            }
            return total;
        }

        public void ShowInvoice()
        {
            Console.WriteLine("----- FACTURA -----");
            Console.WriteLine($"Cliente: {ClienteNombre} (ID: {ClienteID})");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Productos:");
            foreach (var product in Order.Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price:C}");
            }
            Console.WriteLine($"{this.CalculateTotal:C}");
            Console.WriteLine($"Monto con el que se paga: {Amount:C}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine("-------------------");
        }
    }
}
