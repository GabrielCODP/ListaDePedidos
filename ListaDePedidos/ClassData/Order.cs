using System;
using System.Collections.Generic;
using System.Text;
using ListaDePedidos.ClassData.Enums;
using System.Globalization;

namespace ListaDePedidos.ClassData
{
    class Order
    {
        private DateTime Moment;
        public OrderStatus status { get; private set; }
        public Client client { get; private set; }

        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();


        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (var item in orderItems)
            {
                sum += item.subTotal();
            }

            return sum;
        }


        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Order moment: {Moment}");
            text.AppendLine($"Order status: {status}");
            text.AppendLine($"Client: {client}");
            text.AppendLine("Order items");

            foreach (OrderItem item in orderItems)
            {
                text.AppendLine($"{item}");
            }

            text.Append($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return text.ToString();
        }


    }
}
