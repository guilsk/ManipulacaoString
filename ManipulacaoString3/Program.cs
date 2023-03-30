namespace ManipulacaoString3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Escolha um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] letras = frase.ToCharArray();
            int hashCode;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] != ' ')
                {
                    hashCode = (int)letras[i];
                    hashCode += n;
                    letras[i] = (char)hashCode;
                    Console.Write(letras[i]);
                }else
                {
                    Console.Write(letras[i]);
                }
                
            }
        }
    }
}