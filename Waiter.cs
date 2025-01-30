
namespace RestaurantProject
{
    public sealed class Waiter : Employee, IAttend
    {
        public int NumberTablesServed { set; get; }
        public Waiter(string name, int id, string phone, int employeeId) : base(name, id, phone, employeeId, "Waiter") 
        {
            this.NumberTablesServed = 0;
        }

        public void Attend(Order order)
        {
            Console.WriteLine($"{Name} entregó la orden {order.OrderId} en la mesa.");
            order.Status = "Entregado";
        }
    }
}
