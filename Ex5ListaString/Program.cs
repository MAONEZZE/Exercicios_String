namespace Ex5ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt;

            Console.Write("Digite uma frase: ");
            txt = Console.ReadLine();

            string[] txtSeparado = txt.Split(" ");

            Console.WriteLine("Caixa Alta: " + txt.ToUpper());
            Console.WriteLine("Caixa Baixa: " + txt.ToLower());
            Console.WriteLine("Quantidade de caracteres: " + txt.Length);
            Console.WriteLine("Primeira palavra da frase: " + txtSeparado[0]);
            Console.WriteLine("Ultima palavra da frase: " + txtSeparado[txtSeparado.Length - 1]);

        }
    }
}