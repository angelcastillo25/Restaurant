namespace RestaurantProject
{
    public sealed class Chef: Employee, IAttend
    {
        public Product PreparingProduct { get; set; }

        public Chef(string name, int id, string phone, int employeeId): base(name, id, phone, employeeId, "Chef")
        {   
            this.PreparingProduct = null;
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
            this.EmployeeId = employeeId;   

        }

        public void Attend(Order order)
        {
            Console.WriteLine($"{Name} está preparando la orden {order.OrderId}.");
            order.Status = "Preparado";
        }
    }
}
