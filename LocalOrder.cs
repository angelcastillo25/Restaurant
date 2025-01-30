namespace RestauranteProject
{
    class LocalOrder : Order
{
    public Waiter AssignedWaiter { get; set; }

    public LocalOrder(int orderId, Waiter waiter) : base(orderId)
    {
        AssignedWaiter = waiter;
    }
}
}
