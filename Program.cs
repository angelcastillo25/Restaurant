namespace RestaurantProject
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            // Crear productos
            var product1 = new Product("Pizza", 12.99m, "Plato");
            var product2 = new Product("Coca Cola", 1.99m, "Bebida");
            var product3 = new Product("Pastel", 3.50m, "Postre");

            // Crear empleados
            var waiter = new Waiter("Juan", 1, "123-456", 101);
            var chef = new Chef("Maria", 2, "987-654", 102);
            var deliveryPerson = new DeliveryPerson("Carlos", 3, "456-789", 103);

            // Registrar entrada de los empleados
            waiter.RegisterEntryTime();
            chef.RegisterEntryTime();
            deliveryPerson.RegisterEntryTime();

            // Crear una orden local
            var localOrder = new LocalOrder(1, waiter);
            localOrder.Products.Add(product1);
            localOrder.Products.Add(product2);

            // Preparar y servir la orden local
            chef.Attend(localOrder);
            waiter.Attend(localOrder);

            //Pagar orden
            Client cliente = new Client("Carlos Pérez", 1, "12345", localOrder);
            Invoice factura = cliente.Pay(250.75m);
            factura.ShowInvoice();
            Console.WriteLine("-------------------");

            // Crear una orden de entrega
            var deliveryOrder = new DeliveryOrder(2, "123 Calle Principal");
            deliveryOrder.Products.Add(product3);
            deliveryOrder.AssignedDeliveryPerson = deliveryPerson;

            // Preparar y entregar la orden de entrega
            chef.Attend(deliveryOrder);
            deliveryPerson.Attend(deliveryOrder);
            Console.WriteLine("------------------------");

            // Registrar salida de los empleados
            waiter.RegisterExitTime();
            chef.RegisterExitTime();
            deliveryPerson.RegisterExitTime();
            Console.WriteLine("------------------------");
        }
    }

}