namespace RestaurantProject

{
    public class Client : Person
    {
        public Order Order { get; set; }
        public Client(string name, int id, string phone, Order order) : base(name, id, phone)
        {
            this.Order = order;
        }

        public Invoice Pay(decimal monto)
        {
            Console.WriteLine($"{Name} está pagando una factura de {monto:C}.");
            return new Invoice(this, monto, Order);
        }
    }
}
