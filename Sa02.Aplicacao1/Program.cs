using Sa02.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.Aplicacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplicativo2RN aplicativo2RN = new Aplicativo2RN();

            Console.WriteLine("Digite o ano desejado*1968*: ");

            int data = int.Parse(Console.ReadLine());
            int diferencaData = aplicativo2RN.OperacaoData(data);

            Console.WriteLine($"diferença: {diferencaData}");


            
        }
    }
}
