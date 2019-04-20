using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26SetNoModelo
{
    public class Aluno
    {
        public Aluno(string nome, int matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }
        
        private int matricula;
        private string nome;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}  Matricula: {this.Matricula}"; 
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.nome.Equals(outro.nome);    
        }

        public override int GetHashCode()
        {

            return this.Nome.GetHashCode();  
        }


    }
}
