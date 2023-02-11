using Sa02.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.Aplicacao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor unitário e o tamanho da frota;");

            Aplicativo6RN aplicativo6RN= new Aplicativo6RN();

            aplicativo6RN.ValorUnitario = int.Parse(Console.ReadLine());

            decimal resultado = aplicativo6RN.Geralzao(20);
            Console.WriteLine(resultado);
        }
    }
}
