using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MVeiculos.Banco;
using MVeiculos.Modelos;

namespace MVeiculos.Menus
{
    internal class Menu
    {
        public void ShowTitle(string titulo)
        {
            int tamanhoTitulo = titulo.Length;
            string asteristico = string.Empty.PadLeft(titulo.Length, '*');
            Console.WriteLine(asteristico);
            Console.WriteLine(titulo);
            Console.WriteLine(asteristico);
        }
        public virtual void Exec() 
        {
            Console.Clear();
        }
    }
}
