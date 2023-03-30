using System.Globalization;

namespace Ex4ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 7, 3, 1, 6, 7, 1, 7, 6, 5, 3, 1, 3, 3, 0, 6, 2, 4, 9, 1, 9, 2, 2, 5, 1, 1, 9, 6, 7, 4, 4, 2, 6, 5, 7,
                                4, 7, 4, 2, 3, 5, 5, 3, 4, 9, 1, 9, 4, 9, 3, 4, 9, 6, 9, 8, 3, 5, 2, 0, 3, 1, 2, 7, 7, 4, 5, 0, 6, 7, 6,
                                2,2,2,9,8,9,3,4,2,3,3,8,0,3,0,8,1,3,5,3,3,6,2,7,6,6,1,4,2,8,2,8,0,6,4,4,4,4,8,6,6,4,5,2,3,8,7,4,9, 4, 6,
                                3,0,3,5,8,9,0,7,2,9,6,2,9,0,4,9,1,5,6,0,4,4,0,7,7,2,3,9,0,7,1,3,8,1,0,5,1,5,8,5,9,3,0,7,9,6,0,8,6,6 };
                

            int i = 0;
            int nMaior = numeros[0];
            

            while (i != numeros.Length) {
                int mult = 1;

                for (int j = i; j < 5 + i; j++)
                {
                    mult = mult * numeros[j];

                    if (mult > nMaior)
                    {
                        nMaior = mult;
                    }
                    
                }

                i = i + 5;
            }

            Console.WriteLine("Maior produto: "+nMaior);
        }
    }
}