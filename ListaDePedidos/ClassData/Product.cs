﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDePedidos.ClassData
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product()
        {
        }

        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

    }
}
