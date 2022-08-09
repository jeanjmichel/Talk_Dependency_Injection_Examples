using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class FuradeiraMakita: IFuradeira
    {
        public void Furar()
        {
            Console.WriteLine("Furando usando uma furadeira da marca Makita");
        }
    }
}
