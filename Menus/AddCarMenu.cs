using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVeiculos.Banco;
using MVeiculos.Modelos;

namespace MVeiculos.Menus;
internal class AddCarMenu : Menu
{
    MVeiculosContext context = new();

    public void adicionarCar()
    {
        Console.WriteLine("Digite o modelo carro a ser adicionado");
        var carModel = Console.ReadLine();
        Console.WriteLine("Digite o ano de fabricação do carro a ser adicionado");
        var CarYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o cor do carro a ser adicionado");
        var CarColor = Console.ReadLine();
        Console.WriteLine("Digite o preço do carro a ser adicionado");
        var carPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha uma das marcas a seguir, se a marca desejada não estiver cadastrada, digite 0 e depois castre-a antes de cadastrar o carro");
        var brands = context.Brands.ToList();
        foreach (var brand in brands)
        {
            Console.WriteLine($"{brand.Id} - {brand.Name}");
        }
        var carBrandId = Convert.ToInt32(Console.ReadLine());
        if (carBrandId == 0)
        {
            Console.WriteLine("Voltando ao menu principal");
            return;
            //colocar menu principal
        }
        var selectedBrand = context.Brands.FirstOrDefault(a => a.Id == carBrandId);
        var car = new Car(name: carModel, carYear: CarYear, color: CarColor, price: carPrice)
        {
            BrandId = selectedBrand.Id,
        };
        context.Add(car);
        context.SaveChanges();
        Console.WriteLine("Carro adicionado com sucesso!");
    }   }

