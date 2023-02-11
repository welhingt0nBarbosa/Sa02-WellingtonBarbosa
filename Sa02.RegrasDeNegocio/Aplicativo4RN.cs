using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegrasDeNegocio
{
    public class Aplicativo4RN
    {
        public IList<Cliente> ClientesEspeciais { get; set; } = new List<Cliente>();
        public decimal Grana {get; set;}

        public decimal DividirValor(decimal d)
        {

            decimal resultado = Grana / d ;
          
            return resultado;

        }

        public void AddCLient(int qtd)
        {
            for (int i = 0; i < qtd; i++)
            {
                ClientesEspeciais.Add(new Cliente() { Salario = DividirValor(qtd)});
                
            }
        }

       

        public void GetCLient()
        {
            Console.WriteLine(ClientesEspeciais.Count);
            foreach (Cliente c in ClientesEspeciais)
            {
                Console.WriteLine(c.Salario);
            }  
        }

    }

    public class Cliente
    {
        public decimal Salario { get; set; }
    }
}
