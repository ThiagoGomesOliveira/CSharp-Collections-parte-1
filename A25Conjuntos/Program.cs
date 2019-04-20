using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Thiago Gomes Oliveira");
            alunos.Add("Juliana Leoni");
            alunos.Add("Luiz Fernando Gomes de Oliveira");

            Console.WriteLine(alunos);
            Imprimir(alunos);

            // adcionando aluno novo para verificar a ordem do SET
            alunos.Add("Gustavo Gomes");
            Imprimir(alunos);
            // Removendo e adcionando aluno no SET
            alunos.Remove("Gustavo Gomes");
            alunos.Add("Pedro Henrique");
            Imprimir(alunos);
            //Adcionando o mesmo aluno no SET
            alunos.Add("Juliana Leoni");
            Imprimir(alunos);

            //ordernando  o SET
            List<string> listaAlunos = new List<string>(alunos);
            listaAlunos.Sort();
            Console.WriteLine(string.Join(", ",listaAlunos));
 
        }


        public static void Imprimir(ISet<string> conjuntos)
        {
            Console.WriteLine(string.Join(", ",conjuntos));
        }
    }
}
