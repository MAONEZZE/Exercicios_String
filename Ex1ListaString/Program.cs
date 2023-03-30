namespace Ex1ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.Write("Digite uma palavra: ");
            texto = Console.ReadLine();

            string[] textoSeparado = texto.Split(" ");
            string[] letrasMaiores = new string[textoSeparado.Length];
            string[] continuacaoP = new string[textoSeparado.Length];


            for (int i = 0; i <  textoSeparado.Length; i++)
            {
                letrasMaiores[i] = textoSeparado[i].Substring(0, 1).ToUpper();
                continuacaoP[i] = textoSeparado[i].Substring(1, textoSeparado[i].Length - 1).ToLower();

                Console.Write(letrasMaiores[i] + continuacaoP[i] + " ");
            }

            
           

        }
    }
}