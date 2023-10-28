namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números a serem somados: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Resultado da soma é : " + Soma(numero1, numero2)) ;
            Console.WriteLine("digite enter para finalizar o programa");
            Console.ReadLine();
    
        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}