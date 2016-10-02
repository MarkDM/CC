using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS3periodo
{
    class Busca
    {

        static int c = 0;


        public int Comparacoes
        {
            get { return c; }

        }

            


        public int BuscaBinaria_(List<int> l, int chave)
        {
            int meio;
            int inicio = 0;
            int fim = l.Count - 1;
            c = 0;

            do
            {
                c++;
                meio = (int)(inicio + fim) / 2;
                if (l[meio] == chave)
                {
                    //Retorna a posição do número na seqüencia.

                    return meio;
                }
                else if (chave > l[meio])
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }
            while (inicio <= fim);

            //Caso o retorno for -1, então o número não existe na sequencia.
            return -1;
        }


    }
}
