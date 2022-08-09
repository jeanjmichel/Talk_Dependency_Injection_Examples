using System;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFuradeira furadeiraMakita = new FuradeiraMakita();
            IFuradeira furadeiraBosh = new FuradeiraBosh();

            Carpinteiro carpinteiro = new Carpinteiro(furadeiraMakita);
            Carpinteiro carpinteiro2 = new Carpinteiro(furadeiraBosh);

            carpinteiro.FurarMadeira();
            carpinteiro2.FurarMadeira();
        }
    }
}