namespace DependencyInjectionExample
{
    public class Carpinteiro
    {
        private IFuradeira Furadeira { get; set; }

        public Carpinteiro(IFuradeira furadeira)
        {
            Furadeira = furadeira;
        }
        public void FurarMadeira()
        {
            Furadeira.Furar();
        }
    }
}
