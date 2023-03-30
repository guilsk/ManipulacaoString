namespace ManipulacaoString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            int palavras = frase.Split(" ").Length;
            Console.WriteLine(palavras);
        }
    }
}