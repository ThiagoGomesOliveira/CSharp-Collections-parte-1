﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso CsharpColecoes = new Curso("C# coleções","Thiago Gomes Oliveira");

            CsharpColecoes.Adiciona(new Aula("Trabalhando com cursos", 21));
            CsharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            CsharpColecoes.Adiciona(new Aula("Modelando com coleções", 40));


            Aluno a1 = new Aluno("Luiz Fernando",001);
            Aluno a2 = new Aluno("Juliana Leoni", 002);
            Aluno a3 = new Aluno("Gustavo Gomes", 003);

            CsharpColecoes.Matricula(a1);
            CsharpColecoes.Matricula(a2);
            CsharpColecoes.Matricula(a3);

            foreach (var aluno in CsharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            // verificar se aluno já está matriculado

            Aluno testeMesmoAluno = new Aluno("Juliana Leoni", 002);
            Console.WriteLine($"Aluno {a2.Nome}  já está matriculado?"  );
            Console.WriteLine(a2.Equals(testeMesmoAluno)? "Está matriculado": "Não está matriculado");
            

        }
    }
}
