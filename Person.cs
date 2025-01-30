namespace RestaurantProject
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }

        public Person(string name, int id, string phone)
        {
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
        }

    }
}