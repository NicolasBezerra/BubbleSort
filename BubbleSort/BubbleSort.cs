using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    class BubbleSort{
        public static List<int> Vetor = new List<int>();
        public static Random numbers = new Random();
        public static Stopwatch timer = new Stopwatch();
        public static void Bubble(){

            for (int i = Vetor.Count - 1; i >= 1; i --){

                for (int j = 0; j < i; j++){

                    if (Vetor[j] > Vetor[i]){
                        int temp = Vetor[j + 1];
                        Vetor[j + 1] = Vetor[j];
                        Vetor[j] = temp;
                    }
                }
                Console.WriteLine(Vetor[i]);
            }
        }
        static void Main(string[] args){
            for (int i = 0; i < 10; i++){
                Vetor.Add(numbers.Next(1,2000));
                Console.WriteLine(Vetor[i]);
            }

            timer.Start();
            for (int i = Vetor.Count; i < 2000; i += 5){
                Console.WriteLine("Organize!");
                Bubble();
                Vetor.Add(numbers.Next(1, 2000));
                Vetor.Add(numbers.Next(1, 2000));
                Vetor.Add(numbers.Next(1, 2000));
                Vetor.Add(numbers.Next(1, 2000));
                Vetor.Add(numbers.Next(1, 2000));
            }

                timer.Stop();
                Console.WriteLine(Vetor.Count);
                Console.WriteLine(timer.Elapsed);
                Console.ReadLine();
        }
    }
}
