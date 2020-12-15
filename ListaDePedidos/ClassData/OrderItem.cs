using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ListaDePedidos.ClassData
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product product;


        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: ${subTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
