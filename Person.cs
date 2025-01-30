abstract class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Phone { get; set; }

    public Person(string name, int id, string phone)
    {
        Name = name;
        Id = id;
        Phone = phone;
    }
}