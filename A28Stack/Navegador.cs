using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28Stack
{
    public class Navegador
    {
        private string atual;
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();

        public Navegador()
        {
            this.atual = "vazia";
            Console.WriteLine("Página atual: " + this.atual);
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            this.atual = url;
            Console.WriteLine("Página atual: "+this.atual);
        }

        internal void Anterior()
        {
            if (this.historicoAnterior.Any())
            {
                historicoProximo.Push(this.atual);
                this.atual = this.historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + this.atual);
            };
        }

        internal void Proxima()
        {
            if (historicoProximo.Any())
            {
                this.historicoAnterior.Push(this.atual);
                this.atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + this.atual);
            }
        }

        

    }
}
