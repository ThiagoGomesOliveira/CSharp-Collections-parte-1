using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedagio pedagio = new Pedagio();

            pedagio.Enfileirar("gol");
            pedagio.Enfileirar("Fusca");
            pedagio.Enfileirar("guincho");

            ICollection<Pedagio> alunos = new HashSet<Pedagio>();
            pedagio.Desfileirar();
        }
    }
}
