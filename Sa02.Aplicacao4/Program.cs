using Sa02.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.Aplicacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("O progama dividirá 5000 reais entre 10 funcionários;");

            Aplicativo4RN aplicativo4RN = new Aplicativo4RN() {ValorASerDividido = 5000};
          

            aplicativo4RN.AddCLient(10);

            aplicativo4RN.GetCLient();

            Console.WriteLine("certo?");
            
        }
    }
}
