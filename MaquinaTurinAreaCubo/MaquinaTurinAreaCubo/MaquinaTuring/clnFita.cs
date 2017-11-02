using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTurinAreaCubo.MaquinaTuring
{
    class clnFita
    {

        public Int32 iTamArestas;       // VALOR INTEIRO PARA TAMNHO FITA
        public string strTamArestas;

        IList<string> listaFita;


        private void montarTamArestas()
        {
            for (int i=0;i<iTamArestas;i++)
            {
                strTamArestas += "X";
            }
        }

    }
}
