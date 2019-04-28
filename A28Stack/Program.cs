using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("Alura.com.br");

            Console.WriteLine("===============================");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            Console.WriteLine("===============================");

            navegador.Proxima();
            navegador.Proxima();
            navegador.Proxima();

        }
    }
}
