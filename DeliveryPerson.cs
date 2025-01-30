namespace RestauranteProject
{
    public sealed class DeliveryPerson : Employee
{
    public DeliveryPerson(string name, int id, string phone, int employeeId) : base(name, id, phone, employeeId, "Delivery Person") { }

    public void DeliverOrder(DeliveryOrder order)
    {
        Console.WriteLine($"{Name} entregó la orden {order.OrderId} en {order.DeliveryAddress}.");
        order.Status = "Entregado";
    }
}
}
