using System;
using ListaDePedidos.ClassData;
using ListaDePedidos.ClassData.Enums;

namespace ListaDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client dadosCliente = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus order = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order dados = new Order(DateTime.Now, order, dadosCliente);

          
            Console.Write("How many items to this order? ");
            int item = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < item; i++)
            {
                Console.WriteLine($"\nEnter {i+1}° item data: ");

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);

                OrderItem orderItem = new OrderItem(quantidade, price, product);
                dados.addItem(orderItem);
            }

            Console.WriteLine("\nOrder Summary: ");

            Console.WriteLine(dados);

        }
    }
}
