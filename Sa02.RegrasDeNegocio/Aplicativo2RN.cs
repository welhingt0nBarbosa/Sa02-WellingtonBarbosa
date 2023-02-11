using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegrasDeNegocio
{
    public class Aplicativo2RN
    {
        public int OperacaoData(int data)
        {
            int anoAtual = DateTime.Today.Year;

            int diferenca = anoAtual- data;

            return diferenca;
        }


    }
}
