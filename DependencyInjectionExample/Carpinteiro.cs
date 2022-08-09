using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
