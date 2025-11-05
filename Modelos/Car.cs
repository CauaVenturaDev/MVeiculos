using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVeiculos.Modelos
{
    public class Car
    {
        public Car(string name, int carYear, string color, int price)
        {
            Name = name;
            CarYear = carYear;
            Color = color;
            Price = price;
        }

        public string Name { get; set; }
        public int CarYear { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }


        public void ShowTechnicalSheet()
        {
            Console.WriteLine($"Carro: {Name}");
        }
    }
}
