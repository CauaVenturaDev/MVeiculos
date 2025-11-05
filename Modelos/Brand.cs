using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using static System.Net.WebRequestMethods;

namespace MVeiculos.Modelos
{
    public class Brand
    {
        public ICollection<Car> Cars { get; set; } = new List<Car>();

        public Brand(string name)
        {
            Name = name;
            Logo = "https://br.pinterest.com/pin/740419994964406035/";
        }
        public void AdicionarCarro(Car car)
        {
            Cars.Add(car);
        }

        public void MostrarCarrosDaMarca()
        {
            Console.WriteLine($"Carros da marca {Name}");
            foreach (var car in Cars)
            {
                Console.WriteLine($"Carro:{car.Name}");
                Console.WriteLine($"Ano:{car.CarYear}");
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
