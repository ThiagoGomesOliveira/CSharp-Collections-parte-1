using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicionando o primeiro nó na 
            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("Quarta");
            // adcionando o segundo nó antes do nó d4
            var d2 = dias.AddBefore(d4, "Segunda");
            // adcionando o terceiro nó entre os nós d2 d4
             dias.AddAfter(d2, "Terça");
            //Adcionando o nó antes do  d2
             dias.AddBefore(d2, "Domingo");

            var d5 = dias.AddAfter(d4, "Quinta");

            var d6 = dias.AddAfter(d5,"Sexta");

           dias.AddAfter(d6, "Sabado");

            foreach (var dia in dias)
            {
                Console.WriteLine("Dias: "+ dia);
            }
           
        }
    }
}
