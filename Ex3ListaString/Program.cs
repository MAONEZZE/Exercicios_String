namespace Ex3ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            char letra = 'D';
            int numLetra = letra + 2;
            Console.WriteLine(numLetra);
            char novaletra = Convert.ToChar(numLetra);
            Console.WriteLine(novaletra);
            */
            string txt;

            Console.Write("Digite alguma coisa para cifra de cesar: ");
            txt = Console.ReadLine().ToUpper();

            char[] arrayCharTxt = txt.ToCharArray();
            int quantidadePosFrente = 2;
            int[] letrasAscii = new int[arrayCharTxt.Length];
            
            for(int i = 0; i <  arrayCharTxt.Length; i++)
            {
                letrasAscii[i] = arrayCharTxt[i] + quantidadePosFrente;
                arrayCharTxt[i] = Convert.ToChar(letrasAscii[i]);
            }

            Console.Write("Texto cifrado: ");
            for (int i = 0; i < arrayCharTxt.Length; i++)
            {
                Console.Write(arrayCharTxt[i]);
            }
            Console.WriteLine();
        }
    }
}