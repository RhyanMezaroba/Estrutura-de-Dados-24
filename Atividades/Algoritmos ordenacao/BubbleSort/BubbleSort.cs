using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {
        //método de ordenação estático
        public static T[] Sort<T>(T[] array) where T : IComparable //<T> = chamado de GENÉRIC(termos genéricos), ou seja, um vetor de um tipo genérico que eu não sei qual vai ser
        {
            for(int i = 0; i < array.Length - 1; i++) // é utilizado (array.Length - 1) por conta da ordenação do programa que sempre começa em 0! Ex: 0 1 2 3 = 4 vetores, mas só vai até o 3
            {
                bool isAnyChange = false;
                for(int j = 0; j < array.Length - 1; j++ )
                {
                    if( array[j].CompareTo(array[j + 1]) > 0) // CompareTo só está disponível por conta da interface IComparable
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }
                if(!isAnyChange)
                    break;
            }

            return array;
        }

        //Método de troca (swap)
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first]; //temp = valor temporário
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (T i in array){
                Console.Write(i + " ");
            }
            Console.Write(" ]\n");
        }
    }
}