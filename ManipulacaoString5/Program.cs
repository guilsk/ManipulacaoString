namespace ManipulacaoString5
{
    internal class Program
    {
        static void imprimirUltimaPalavra(string x)
        {
            int posEspaco = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                    posEspaco = i+1;
            }
            Console.WriteLine(x.Substring(posEspaco));
        }
        static void imprimirPrimeiraPalavra(string x)
        {
            
            Console.WriteLine(x.Substring(0, x.IndexOf(' ') +1));
            

        }
        static void imprimirQtdCaracteres(string x)
        {
            Console.WriteLine(x.Length);
        }
        static void imprimirMinusculo(string x)
        {
            Console.WriteLine(x.ToLower());
        }
        static void imprimirMaiusculo(string x)
        {
            Console.WriteLine(x.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string x = Console.ReadLine();
            imprimirMaiusculo(x);
            imprimirMinusculo(x);
            imprimirQtdCaracteres(x);
            imprimirPrimeiraPalavra(x);
            imprimirUltimaPalavra(x);
        }
    }
}