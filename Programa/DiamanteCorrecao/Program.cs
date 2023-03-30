namespace DiamanteCorrecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraInfo = 'E';
            char letraA = 'A';
            char letra = 'A';
            int espacoDaMargem = letraInfo - letraA;
            int espacoEntreLetra = 0;

            for (int linha = 0; linha < 4; linha++)
            {
                for (int i = 0; i < espacoDaMargem; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);

                for(int  i = 0; i < espacoEntreLetra; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                {
                    Console.Write(letra);
                }

                Console.Write(letraInfo);

                letra++;
                espacoDaMargem--;
                espacoEntreLetra += 2;

                Console.WriteLine();
            }

            Console.WriteLine(letraInfo);

            for (int i = 0; i < espacoEntreLetra; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(letraInfo);
        }
    }
}