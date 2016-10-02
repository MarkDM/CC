using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace APS3periodo
{
    public delegate void Progress(int val);


    class Ordenacao
    {
        public event Progress onProgressUpdate;
        int progress = 0;
        public Stopwatch sw = new Stopwatch();
        
        #region Bubble Sort
        public List<int> bubbleSort(List<int> l)
        {
            int tamanho = l.Count;
            int comparacoes = 0;
            int trocas = 0;
            progress = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                progress++;
               onProgressUpdate(progress);
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (l[j] > l[j + 1])
                    {
                        int aux = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = aux;
                        trocas++;

                    }


                }
            }

                     



            return l;
        }

        #endregion


        #region quick sort


        public List<int> QuickSort(List<int> input, int left, int right)
        {
           

            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }

            return input;
        }


        private int Partition(List<int> input, int left, int right)
        {
            int pivot = input[right];
            int temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;
            
            return i;
        }




        #endregion


        #region Selection Sort

        public List<int> selectionSort(List<int> vetor)
        {
            int min, aux;
            progress = 0;

            for (int i = 0; i < vetor.Count - 1; i++)
            {
                min = i;
                progress++;
                onProgressUpdate(progress);
                for (int j = i + 1; j < vetor.Count; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }

        #endregion


    }
}
