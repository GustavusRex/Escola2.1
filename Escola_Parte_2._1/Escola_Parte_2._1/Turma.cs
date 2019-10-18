using System;
using System.Collections.Generic;


namespace Escola_Parte_2._1
{
    class Turma
    {

        public Professor professor = new Professor();
        public List<Aluno> ListaAlunosAtribuidos = new List<Aluno>();

        public int Codigo;
        public int Tamanho;

        public void CodigoTurma()
        {
            Random random = new Random();  // Ramdom para gerar uma codigo da turma aleatorio
            Codigo = random.Next(1000);
        }


        public void ExibirProfessor() // Exibir professor dentro da turma já atribuidas a tal
        {
            Console.WriteLine($"A Turma {Codigo} tem o professor: ");

            if (professor.Idade == 0)
            {
                Console.WriteLine("Não há professor nessa turma");
            }
            else
            {
                Console.WriteLine($"O professor {professor.Nome}, com o sexo {professor.Sexo}, de idade {professor.Idade}, com o registro {professor.Registro}");
            }
        }

        public void ExibirAluno() // Exibir aluno dentro da turma já atribuidas a tal
        {

            Console.WriteLine($"A Turma {Codigo} tem o Aluno: ");
            if (ListaAlunosAtribuidos.Count == 0)
            {
                Console.WriteLine($"A Turma {Codigo} não há alunos");
            }

            else
            {

                foreach (Aluno aluno in ListaAlunosAtribuidos) // Para cada objeto aluno irá rodar dentro da ListaAlunosAtribuidos
                {
                    Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                    $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");
                }
            }
        }
        public void MostrarTudo() // Mostrar o Geral do cadastro
        {
            Console.WriteLine($"A Turma {Codigo} tem o professor: ");

            if (professor.Idade == 0)
            {
                Console.WriteLine("Não há professor nessa turma");
            }
            else
            {
                Console.WriteLine($"O professor {professor.Nome}, com o sexo {professor.Sexo}, de idade {professor.Idade}, com o registro {professor.Registro}");
            }

            Console.WriteLine($"A Turma {Codigo} tem o Aluno: ");
            if (ListaAlunosAtribuidos.Count == 0)
            {
                Console.WriteLine($"A Turma {Codigo} não há alunos");
            }

            else
            {

                foreach (Aluno aluno in ListaAlunosAtribuidos) // Para cada objeto aluno irá rodar dentro da ListaAlunosAtribuidos
                {
                    Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                    $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");
                }
            }

        }
    }

}