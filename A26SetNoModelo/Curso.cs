﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace A26SetNoModelo
{
    public class Curso
    {
        //campo privado contendo a lista de aulas
        private IList<Aula> aulas;

        //alunos deve ser ISET e deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new  ReadOnlyCollection<Aluno>(alunos.ToList());

            }
        }

        /// <summary>
        /// Retornamos uma coleção somente leitura, isto é,
        /// ReadOnlyCollection, para proteger o campo privado aulas
        /// </summary>
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        /// <summary>
        /// Encapsula a adição de uma aula à coleção de aulas do curso
        /// </summary>
        /// <param name="aula">Aula a ser adicionada</param>
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        internal void Matricula(Aluno aluno)
        {
           alunos.Add(aluno) ;
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }



        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        /// <summary>
        /// Obtém o tempo total do curso (somando os tempos das aulas)
        /// </summary>
        public int TempoTotal
        {
            get
            {
                ////somando o tempo total
                ////através de um acumulador
                ////===============================
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                ////somando o tempo total
                ////com o método Sum (LINQ)
                ////===============================
                //LINQ = Language Integrated Query
                //Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        /// <summary>
        /// Obtém texto para impressão de detalhes do curso
        /// </summary>
        /// <returns>Texto com detalhes do curso</returns>
        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool VerificarAlunoMatriculado(Aluno aluno)
        {
            return this.Alunos.Equals(aluno.Nome);
        }
    }
}