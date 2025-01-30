namespace RestauranteProject
{
    class DeliveryOrder : Order
{
    public string DeliveryAddress { get; set; }
    public DeliveryPerson AssignedDeliveryPerson { get; set; }

    public DeliveryOrder(int orderId, string address) : base(orderId)
    {
        DeliveryAddress = address;
    }
}
}
