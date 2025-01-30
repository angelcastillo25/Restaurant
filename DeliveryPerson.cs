namespace RestaurantProject
{
    public sealed class DeliveryPerson : Employee, IAttend
    {
        public DeliveryPerson(string name, int id, string phone, int employeeId) : base(name, id, phone, employeeId, "Delivery Person") 
        { 

        }

        public void Attend(Order order)
        {
            Console.WriteLine($"{Name} entregó la orden {order.OrderId} ");
            // en {order.DeliveryAddress}.
            order.Status = "Entregado";
        }
    }
}