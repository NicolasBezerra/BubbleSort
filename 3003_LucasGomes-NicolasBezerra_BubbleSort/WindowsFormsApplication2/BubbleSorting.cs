using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    class BubbleSorting{
        public void Sort(List<int> Vetor, Random numbers, Stopwatch timer){
            timer.Start();
            for (int l = Vetor.Count - 1; l >= 1; l--){
                for (int j = 0; j < l; j++){
                    if (Vetor[j] > Vetor[l]){
                        int temp = Vetor[j + 1];
                        Vetor[j + 1] = Vetor[j];
                        Vetor[j] = temp;
                    }
                }
            }     
            timer.Stop();
        }
    }
}
