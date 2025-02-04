namespace RestaurantProject
{
    public abstract class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Position { get; set; }
        public DateTime EntryTime { get; private set; }
        public DateTime ExitTime { get; private set; }

        public Employee(string name, int id, string phone, int employeeId, string position) : base(name, id, phone)
        {
            this.EmployeeId = employeeId;
            this.Position = position;
        }

        public void RegisterEntryTime()
        {
            this.EntryTime = DateTime.Now;
            Console.WriteLine($"{Name} marcó entrada a las {EntryTime}.");
        }

        public void RegisterExitTime()
        {
            ExitTime = DateTime.Now;
            Console.WriteLine($"{Name} marcó salida a las {ExitTime}.");
        }
    }
}
