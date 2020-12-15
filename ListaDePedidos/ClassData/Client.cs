using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDePedidos.ClassData
{
    class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirtDate { get; private set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birtDate)
        {
            Name = name;
            Email = email;
            BirtDate = birtDate;
        }
        public override string ToString()
        {
            return $"Client: Alex Green ({BirtDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
