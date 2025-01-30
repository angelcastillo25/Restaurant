using Restaurante;

namespace RestauranteProject
{
    public sealed class Chef(string name, int id, string phone, int employeeId) : Employee(name, id, phone, employeeId, "Chef")
{
        public void PrepareOrder(Order order)
    {
        Console.WriteLine($"{Name} está preparando la orden {order.OrderId}.");
        order.Status = "Preparado";
    }
}
}
