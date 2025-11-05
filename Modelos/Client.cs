using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVeiculos.Modelos
{
    public class Client
    {
        public Client(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public Car Car { get; set; }
    }
}
