namespace Ex6ListaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string planilha = File.ReadAllText(@"C:\Users\ruans\OneDrive\Área de Trabalho\AcadP\Cidades.csv");
            string[] linhas = planilha.Split("\r\n");//a lista está sendo quebrada em \r\n
            string[] nomeEstadoCidade = new string[linhas.Length];

            int posCidade = 2;
            int posEstado = 3;

            int j = 0;
            for(int i = 1; i < linhas.Length; i++) //--> se i começar no 0 pegaria os titulos da tabela, por isso e quando começa em 1 deixa a posição
                                                   //0 do array nula, assim tendo que usar o j
            {
                string[] colunas = linhas[i].Split(";");

                nomeEstadoCidade[j] = colunas[posCidade] + "; "+ colunas[posEstado];

                j++;
            }

            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            for(int i = 0; i < alfabeto.Length; i++)
            {
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}");
                for (int k = 0; k < nomeEstadoCidade.Length; k++)
                {
                    char primeiraLetra = alfabeto[i];
                    if (nomeEstadoCidade[k] != null && nomeEstadoCidade[k].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = nomeEstadoCidade[k].IndexOf(";");
                        string cidadeSemEstado = nomeEstadoCidade[k].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t"+cidadeSemEstado);//\t server para dar um tab antes da string
                    }
                }
            }

            string[] estados = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"};


            for (int i = 0; i < alfabeto.Length; i++)
            {
                string estado = estados[i];
                Console.WriteLine($"\nCidades do estado: {estado}\n");

                for (int k = 0; k < nomeEstadoCidade.Length; k++)
                {
                    if (nomeEstadoCidade[k] != null && nomeEstadoCidade[k].Contains(estado))
                    {
                        int posicaoInicioEstado = nomeEstadoCidade[k].IndexOf(";");
                        string cidadeSemEstado = nomeEstadoCidade[k].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t"+ cidadeSemEstado);
                    }
                }
            

            }


        }
    }
}