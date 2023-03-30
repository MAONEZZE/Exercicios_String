namespace Ex2ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string texto = Console.ReadLine();
            string[] txtSeparado = texto.Split(" ");
            int numPalavras = txtSeparado.Length;

            Console.WriteLine("Número de palavras: "+numPalavras);

            

        }
    }
}