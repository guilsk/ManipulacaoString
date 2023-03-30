namespace ManipulacaoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            string[] palavra = frase.Split(" ");
            for (int i = 0; i < frase.Length; i++)
            {
                palavra[i] = palavra[i].Substring(0, 1).ToUpper() + palavra[i].Substring(1).ToLower();
                Console.Write($"{palavra[i]} ");
            }
            Console.WriteLine();
        }
    }
}