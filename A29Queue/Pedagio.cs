using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29Queue
{
    public class Pedagio
    {
        private Queue<string> veiculos = new Queue<string>();

        public void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila {veiculo}");
            veiculos.Enqueue(veiculo);
            ListarFilaPedagio();
        }

        private void ListarFilaPedagio()
        {
            Console.WriteLine("FILA: ");
            foreach (var v in this.veiculos)
            {
                Console.WriteLine(v);
               
            }
            Console.WriteLine();
        }

        public void Desfileirar()
        {
            if (this.veiculos.Any())
            {
                // verificar  veículo seguinte sem que ele seja removido
                if (this.veiculos.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está efetuando o pagamento");
                }

                Console.WriteLine($"Saiu da fila {this.veiculos.Dequeue()}");
                ListarFilaPedagio();
            }
          
        }

    }
}
