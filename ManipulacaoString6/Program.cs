namespace ManipulacaoString6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você quer...");
            Console.WriteLine("(1) Agrupar as cidades pela primeira letra?");
            Console.WriteLine("(2) Agrupar as cidades pelo seu respectivo estado?");
            Console.Write(">> ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] cidade = new string[6000];

            if (opcao == 1)
            {
                using (StreamReader reader = new StreamReader("D:/Visual Studio Projects/Cidades_-_Cidades.csv"))
                    // A <= 90 = Z
                    for (int i = 65; i <=90; i++)
                    {
                        if(i > 65)
                        {
                            reader.BaseStream.Seek(0, SeekOrigin.Begin);
                            reader.DiscardBufferedData();
                        }

                        reader.ReadLine();

                        char letraAtual = Convert.ToChar(i);
                        Console.WriteLine(letraAtual);

                        int contador = 0;

                        do
                        {
                            cidade[i] = reader.ReadLine().Split(';')[2];
                            if(letraAtual == cidade[i][0])
                            {
                                Console.WriteLine(cidade);
                            }

                        } while(!reader.EndOfStream);
                    }                
            }
            else if (opcao == 2)
            {

            }



        }
    }
}