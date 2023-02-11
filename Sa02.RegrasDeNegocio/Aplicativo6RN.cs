using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegrasDeNegocio
{
    public class Aplicativo6RN
    {
        public int ValorUnitario { get; set; }
        
        public decimal Geralzao(decimal qtdFrota)
        {
            decimal totalGeral = qtdFrota * ValorUnitario;
            return totalGeral;
        }

    }
}
