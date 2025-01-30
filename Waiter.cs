
namespace RestauranteProject
{
    public sealed class Waiter : Employee
{
    public Waiter(string name, int id, string phone, int employeeId) : base(name, id, phone, employeeId, "Waiter") { }

    public void ServeOrder(LocalOrder order)
    {
        Console.WriteLine($"{Name} entregó la orden {order.OrderId} en la mesa.");
        order.Status = "Entregado";
    }
}
}
