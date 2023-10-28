namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
            Carro carro = new Carro();
            carro.DigaSeuNome();
            Aviao aviao = new Aviao();
            aviao.DigaSeuNome();
            MeusTestes.Carro carroMeusTestes = new MeusTestes.Carro();
            carroMeusTestes.DigaSeuNome();
            Console.ReadKey();
        }
    }
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Meu nome é carro");
        }
    }

    class Aviao
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Meu nome é avião");
        }
    }
}
namespace MeusTestes
{
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Meu nome é carro dentro do namespace MeusTestes");
        }
    }
}