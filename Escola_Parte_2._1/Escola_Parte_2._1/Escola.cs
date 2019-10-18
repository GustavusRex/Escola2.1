using System;
using System.Collections.Generic;
using System.Linq;



namespace Escola_Parte_2._1
{
    class Escola
    {
        public List<Aluno> ListaAlunos = new List<Aluno>();
        public List<Turma> Listaturma = new List<Turma>();
        public List<Professor> ListaProfessor = new List<Professor>();
        uint NumeroProfessores;
        uint NumeroTurma;
        uint NumeroAlunos;
        int n;



        public void ListaDeTurmas() // Metodo para cadastrar as turmas dentro de escola
        {
            Console.WriteLine("Digite a quantidade de turmas");
            NumeroTurma = Sonumeros2(Console.ReadLine()); // Metodo para validar numero 

            for (int i = 0; i < NumeroTurma; i++) // For para rodar quantas vezes quer cadastrar uma turma
            {
                Turma turma = new Turma();
                turma.CodigoTurma();
                Console.WriteLine("Digite o tamanho da turma");
                turma.Tamanho = int.Parse(Console.ReadLine());
                Listaturma.Add(turma);


                Console.WriteLine($"Os codigos das turmas são: {turma.Codigo}");


            }

            Console.WriteLine($"Turma(s) cadastradas! quantidade de turmas cadastradas {NumeroTurma}");

        }

        public void ListaDeProfessores() // Metodo para cadastrar os professores dentro dentro de escola
        {
            Console.WriteLine("Digite o número de professores que serão cadastrados na lista");
            NumeroProfessores = Sonumeros2(Console.ReadLine()); //Metodo para validar numero 

            for (int i = 0; i < NumeroProfessores; i++) // For para rodar quantas vezes quer cadastrar um professor
            {
                Professor professor = new Professor();
                Console.WriteLine($"Digite o 1° nome do(a) {i + 1}° Professor(a)");
                professor.ColoqueAsInformacaosProfessor();
                //if (!professor.ColoqueAsInformacaosProfessor()) return ;
                ListaProfessor.Add(professor);
            }
            Console.WriteLine($"Professor(s) cadastrado com sucesso! quantidade de turmas cadastradas {NumeroProfessores}");


        }

        public void ListaDeAlunos() // Metodo para cadastrar os alunos dentro dentro de escola
        {
            Console.WriteLine("\nDigite a quantidade de alunos para o cadastro");

            NumeroAlunos = Sonumeros2(Console.ReadLine()); //Metodo para validar numero 

            for (int i = 0; i < NumeroAlunos; i++) // For para rodar quantas vezes quer cadastrar alunos
            {
                Aluno aluno = new Aluno();
                Console.WriteLine($"Digite o nome do(a) {i + 1}° Aluno (a)");
                aluno.ColoqueAsInformacaosAlunos();
                ListaAlunos.Add(aluno);
            }
            Console.WriteLine($"Aluno(s) cadastrado com sucesso! quantidade de turmas cadastradas {NumeroAlunos}");

        }

        public void AddProfessorTurma() // Metodo para colocar uma professor a uma turma
        {
            Console.Write("Digite o número de registro: ");
            n = Sonumeros(Console.ReadLine());
            Professor professor = ListaProfessor.Find(x => x.Registro == n);

            if (professor == null)
                Console.WriteLine("Registro não existe");
            else
                professor = ListaProfessor.Where(a => a.Registro == n).FirstOrDefault(); // Metodo para procurar dentro da lista de professores o professor com o registro cadastrado

            Console.Write("Digite o número do codigo da turma: ");
            int nu = Sonumeros(Console.ReadLine());
            Turma turma = Listaturma.Find(x => x.Codigo == nu);

                Listaturma.Where(a => a.Codigo == nu).FirstOrDefault().professor = professor; // Adiciona o Professor encontrado na lista de professores dentro da turma selecionada

                if (Listaturma.GroupBy(a => a.professor).Any(a => a.Count() == 2))
                {
                    ListaProfessor.Remove(professor);
                }

           
        }





        public void AddAlunosTurma()
        {

            Console.Write("Digite o número de matricula: ");
            n = Sonumeros(Console.ReadLine());
            Aluno aluno = ListaAlunos.Find(x => x.Matricula == n);
            if (aluno == null)
            {
                Console.WriteLine("Matricula não existe");
            }
            else
            {
                aluno = ListaAlunos.Where(a => a.Matricula == n).FirstOrDefault(); // Metodo para procurar dentro da lista de alunos o aluno com a matricula cadastrada
            }
            Console.Write("Digite o número do código da turma: ");
            int nu = Sonumeros(Console.ReadLine());
            Turma turma = Listaturma.Find(x => x.Codigo == nu);

            if (turma.ListaAlunosAtribuidos.Count == turma.Tamanho)
            {
                Console.WriteLine("Essa turma está cheia");
            }
            else
            {
                Listaturma.Where(a => a.Codigo == nu).FirstOrDefault().ListaAlunosAtribuidos.Add(aluno); // Adiciona o aluno encontrado na lista de Alunos dentro da turma selecionada
                ListaAlunos.Remove(aluno);
            }


        }

        public void MostrarFinalAluno()
        {
            foreach (Turma turm in Listaturma)
                turm.ExibirAluno();
        }
        public void MostrarFinalProfessor()
        {
            foreach (Turma turm in Listaturma)
            {
                turm.ExibirProfessor();
            }
        }
        public void MostrarAlunos()
        {
            foreach (Aluno aluno in ListaAlunos)

                Console.WriteLine($"alunos {aluno.Nome} do sexo {aluno.Sexo} com a idade {aluno.Idade}, " +
                                  $"registrado com a matricula: {aluno.Matricula}\n O aluno tem Bolsa? {aluno.Bolsista}");

        }
        public void MostrarProfessor()
        {
            foreach (Professor prof in ListaProfessor)

                Console.WriteLine($"Professores {prof.Nome} do sexo {prof.Sexo} com a idade {prof.Idade}, " +
                                  $" com o número de registro {prof.Registro}\n");
        }
        public void MostrarTurmas()
        {
            foreach (Turma turma in Listaturma)

                Console.WriteLine($"O codigo da turma é {turma.Codigo}");
        }

        public void MostrarTutto()
        {
            foreach (Turma turm in Listaturma)
            {
                turm.MostrarTudo();
            }

        }
        static int Sonumeros(string s) // Metodo para aceitar apenas numeros dentro do string para converter em int
        {
            int n;
            while (!int.TryParse(s, out n))
            {
                Console.WriteLine("Numero invalido");
                s = Console.ReadLine();

            }
            return n;

        }
        static uint Sonumeros2(string s) // Metodo para aceitar apenas numeros dentro do string para converter em uint 
        {
            uint n;
            while (!uint.TryParse(s, out n))
            {
                Console.WriteLine("\nNúmero digitado invalido, porfavor digite um número inteiro e positivo\n");
                s = Console.ReadLine();

            }
            return n;

        }


    }
}
