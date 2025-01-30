namespace RestaurantProject
{
    public sealed class DeliveryPerson : Employee, IAttend
    {
        public int NumberOrdersDelivered { set; get; }

        public DeliveryPerson(string name, int id, string phone, int employeeId) : base(name, id, phone, employeeId, "Delivery Person") 
        {   
            this.NumberOrdersDelivered = 0;
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
            this.EmployeeId = employeeId;

        }

        public void Attend(Order order)
        {
            DeliveryOrder orderD = order as DeliveryOrder;  

            Console.WriteLine($"{Name} entregó la orden {order.OrderId} en {orderD.DeliveryAddress}.");
            
            order.Status = "Entregado";
        }
    }
}