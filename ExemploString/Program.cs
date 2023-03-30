 namespace ExemploString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Olá Mundo";

            String outrotxt = new String("Olá Mundp"); // iguais

            char primeiraLetratxt = txt[0];

            char ultimaLetratxt = txt[txt.Length - 1];

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            string txtSubstring = txt.Substring(1, 5);
            Console.WriteLine(txtSubstring);

            string[] mensagemSeparada = txt.Split(" ");

            for (int i = 0; i < mensagemSeparada.Length; i++)
            {
                Console.WriteLine(mensagemSeparada[i]);
            }

            Console.WriteLine();
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            if(txt.StartsWith("Olá", StringComparison.OrdinalIgnoreCase)) //StringComparison.OrdinalIgnoreCase ignora o case da palavra
            {
                Console.WriteLine("Inicia-se com Olá");
            }

            if (txt.EndsWith("Mundo"))
            {
                Console.WriteLine("Termina-se com Mundo");
            }

            if(txt.Contains("mun", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contem mun");
            }

            int txtIndex = txt.IndexOf("m", StringComparison.OrdinalIgnoreCase);

            string txtEspacos = "      aaaaaa     ";
            Console.WriteLine(txtEspacos.Trim());

            Console.WriteLine(txt.Replace(" ", "-"));

            string remocaoTxt = txt.Remove(0, 4);

            Console.WriteLine(remocaoTxt);

            Console.WriteLine(txt.PadLeft(15, '-'));
            Console.WriteLine(txt.PadRight(15, '-'));

            /*Como ler um arquivo e jogar pra ca
             * string municipios = File.ReadAllText(@"caminho do arquivo");
             */




        }
    }
}