namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();

            string[] nomes = { "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

            int numFruta = rdm.Next(nomes.Length);
            string nomeFruta = nomes[numFruta];
            char[] nomeFarray = nomeFruta.ToCharArray();
            char letraChutada;
            int contadorErros = 0;
            char[] arrayLetrasChutadas = new char[nomeFruta.Length];

            Console.WriteLine("----Jogo da Forca----");

            while (contadorErros != 5)
            {
                Console.WriteLine();
                Console.Write("Digite o nome de uma fruta: ");
                letraChutada = Convert.ToChar(Console.ReadLine());

            
                if (nomeFruta.Contains(letraChutada))
                {
                    for (int i = 0; i < nomeFruta.Length; i++)
                    {
                        if(i == 0)
                        {
                            for(int j = 0; j < nomeFruta.Length; j++)
                            {
                                arrayLetrasChutadas[i] = '_';
                            }
                        }

                        if (letraChutada == nomeFarray[i])   
                        {
                            arrayLetrasChutadas[i] = letraChutada;
                            
                        }
                        Console.Write(arrayLetrasChutadas[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    contadorErros++;
                }
            }
            Console.WriteLine(nomeFruta);
        }
    }
}