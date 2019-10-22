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
        public List<Coordenador> ListaCoordenador = new List<Coordenador>();
        uint NumeroProfessores;
        uint NumeroTurma;
        uint NumeroAlunos;
        uint NumeroCoordenadores;
        int n;



        public void ListaDeTurmas() // Metodo para cadastrar as turmas dentro de escola
        {
            Console.WriteLine("Digite a quantidade de turmas");
            NumeroTurma = Sonumeros2(Console.ReadLine()); // Metodo para validar numero 

            for (int i = 0; i < NumeroTurma; i++) // For para rodar quantas vezes quer cadastrar uma turma
            {
                Turma turma = new Turma();
                turma.CodigoTurma(this);
                Console.WriteLine("Digite o tamanho da turma");
                turma.Tamanho = Sonumeros2(Console.ReadLine());
                Listaturma.Add(turma);


                Console.WriteLine($"Os codigos das turmas são: {turma.Codigo}");


            }

            Console.WriteLine($"Turma(s) cadastradas! quantidade de turmas cadastradas {NumeroTurma}");
            Console.ReadKey();
        }

        public bool ListaDeProfessores() // Metodo para cadastrar os professores dentro dentro de escola
        {
            if (ListaCoordenador.Count == 0)
            {
                Console.WriteLine("Não há coordenadores cadastrados, não há como cadastrar um professor");
                Console.WriteLine("Deseja cadastrar um coordenador para prosseguir? Aperte Qualquer tecla para sim e aperte esc para não");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Digite o número de coordenadores que serão cadastrados na lista");
                    ListaDeCoordenadores();
                }
            }

            Console.Clear();
            Console.WriteLine("Coordenadores disponiveis");
                MostrarCoordenador();
                Console.WriteLine("Digite o número de professores que serão cadastrados na lista");
                NumeroProfessores = Sonumeros2(Console.ReadLine()); //Metodo para validar numero 

                for (int i = 0; i < NumeroProfessores; i++) // For para rodar quantas vezes quer cadastrar um professor
                {
                    Professor professor = new Professor();
                    Console.WriteLine($"Digite o 1° nome do(a) {i + 1}° Professor(a)");
                    professor.ColoqueAsInformacaosProfessor(this);
                    //if (!professor.ColoqueAsInformacaosProfessor()) return ;
                    ListaProfessor.Add(professor);
                }
                Console.WriteLine($"Quantidade de  cadastradas {NumeroProfessores}");
                Console.ReadKey();

            return true;
        }

        public void ListaDeAlunos() // Metodo para cadastrar os alunos dentro dentro de escola
        {
            Console.WriteLine("\nDigite a quantidade de alunos para o cadastro");

            NumeroAlunos = Sonumeros2(Console.ReadLine()); //Metodo para validar numero 

            for (int i = 0; i < NumeroAlunos; i++) // For para rodar quantas vezes quer cadastrar alunos
            {
                Aluno aluno = new Aluno();
                Console.WriteLine($"Digite o nome do(a) {i + 1}° Aluno (a)");
                aluno.ColoqueAsInformacaosAlunos(this);
                ListaAlunos.Add(aluno);
            }
            Console.WriteLine($"Quantidade de alunos cadastrado com sucesso! {NumeroAlunos}");
            Console.ReadKey();
        }

        public void ListaDeCoordenadores()
        {
            Console.Clear();
            Console.WriteLine("Digite a quantidade de coordenadores para o cadastro");

            NumeroCoordenadores = Sonumeros2(Console.ReadLine());

            for (int i = 0; i< NumeroCoordenadores; i++)
            {
                Coordenador coordenador = new Coordenador();
                Console.WriteLine($"Digite o nome do(a) {i + 1}° Coordenador (a)");
                coordenador.ColoqueAsInformacaosCoordenador(this);
                ListaCoordenador.Add(coordenador);
            }

            Console.WriteLine($"Quantidade de Coordenadores cadastrados com sucesso: { NumeroCoordenadores}");
            Console.ReadKey();


        }

        public void AddProfessorTurma() // Metodo para colocar uma professor a uma turma
        { 
            
            Console.Write("Digite o número de registro: ");
            n = Sonumeros(Console.ReadLine());
            Professor professor = ListaProfessor.Find(x => x.Registro == n);

            while (professor == null)
            {
                Console.WriteLine("Professor existe porém, seu registro está incorreto");
                Console.Write("Digite novamente: ");
                n = Sonumeros(Console.ReadLine());
                professor = ListaProfessor.Find(x => x.Registro == n);
            }


            Console.Write("Digite o número do codigo da turma: ");

             n = Sonumeros(Console.ReadLine());
            Turma turma = Listaturma.Find(x => x.Codigo == n);
            while (turma == null)
            {
                Console.WriteLine("Turma existe porém seu codigo está incorreto");
                Console.Write("Digite novamente: "); 
                n = Sonumeros(Console.ReadLine());
                turma = Listaturma.Find(x => x.Codigo == n);
            }

            turma.professor = professor; // Adiciona o Professor encontrado na lista de professores dentro da turma selecionada

                if (Listaturma.Where(a => a.professor==professor).Count() == 2)
                {
                    ListaProfessor.Remove(professor);
                }

           
        }

        public void AddCoordenadorTurma()
        {
            Console.Write("Digite o número de registro: ");
            n = Sonumeros(Console.ReadLine());
            Coordenador coordenador = ListaCoordenador.Find(x => x.Registro == n);

            while (coordenador == null)
            {
                Console.WriteLine("Coordenador existe porém, seu registro está incorreto");
                Console.Write("Digite novamente: ");
                n = Sonumeros(Console.ReadLine());
               coordenador = ListaCoordenador.Find(x => x.Registro == n);
            }
              

            Console.Write("Digite o número o codigo da turma: ");
            n = Sonumeros(Console.ReadLine());
            Turma turma = Listaturma.Find(x => x.Codigo == n);
            while (turma == null)
            {
                Console.WriteLine("Turma existe porém seu codigo está incorreto");
                Console.Write("Digite novamente: ");
                n = Sonumeros(Console.ReadLine());
                turma = Listaturma.Find(x => x.Codigo == n);
            }

            turma.Coordenador = coordenador;
        }

        public void RemoveAluno()
        {
            if (Listaturma.Count == 0)
                Console.WriteLine("Não existe turmas para remover um aluno\n" +
                    " Aperte qualquer tecla para retornar");
            else
            {

                Console.Write("Digite o codigo da turma: ");
                n = Sonumeros(Console.ReadLine());
                Turma turma = Listaturma.Find(x => x.Codigo == n);
                while (turma == null)
                {
                    Console.WriteLine("Turma existe porém seu codigo está incorreto");
                    Console.Write("Digite novamente: ");
                    n = Sonumeros(Console.ReadLine());
                    turma = Listaturma.Find(x => x.Codigo == n);
                }
                if (turma.ListaAlunosAtribuidos.Count == 0)
                    Console.WriteLine("Não existe alunos dentro da turma para ser removido\n");
                else
                {
                    Console.Write("Digite a matricula da aluno: ");
                    n = Sonumeros(Console.ReadLine());
                    Aluno aluno = turma.ListaAlunosAtribuidos.Find(a => a.Matricula == n);

                    while(aluno == null)
                    {
                        Console.WriteLine("O aluno existe porém, a matricula está incorreto");
                        Console.Write("Digite novamente: ");
                        n = Sonumeros(Console.ReadLine());
                        aluno = turma.ListaAlunosAtribuidos.Find(a => a.Matricula == n);
                    }

                    ListaAlunos.Add(aluno);
                    turma.ListaAlunosAtribuidos.Remove(aluno);
                }
            }
            
        }

        public void RemoveProfessor()
        {
            if (Listaturma.Count == 0)
                Console.WriteLine("Não existe turmas para remover um Professor\n" +
                    " Aperte qualquer tecla para retornar");
            else
            {
                Console.Write("Digite o codigo da turma: ");
                n = int.Parse(Console.ReadLine());
                Turma turma = Listaturma.Find(x => x.Codigo == n);
                while (turma == null)
                {
                    Console.WriteLine("Turma existe porém seu codigo está incorreto");
                    Console.Write("Digite novamente: ");
                    n = Sonumeros(Console.ReadLine());
                    turma = Listaturma.Find(x => x.Codigo == n);
                }
                Professor professor = turma.professor;
                if (!ListaProfessor.Exists(a => a.Registro == professor.Registro))
                {
                    ListaProfessor.Add(professor);
                    
                }
                turma.professor = null;
            }
        }

        public void RemoveCoordenador()
        {
            if (Listaturma.Count == 0)
            Console.WriteLine("Não existe turmas para remover um Coordenador\n" +
                " Aperte qualquer tecla para retornar");

            else
            {
                Console.Write("Digite o codigo da turma: ");
                n = int.Parse(Console.ReadLine());
                Turma turma = Listaturma.Find(x => x.Codigo == n);
                while (turma == null)
                {
                    Console.WriteLine("Turma existe porém seu codigo está incorreto");
                    Console.Write("Digite novamente: ");
                    n = Sonumeros(Console.ReadLine());
                    turma = Listaturma.Find(x => x.Codigo == n);
                }
                turma.Coordenador = null;
            }
        }



        public void AddAlunosTurma()
        {

            Console.Write("Digite o número de matricula: ");
            n = Sonumeros(Console.ReadLine());
            Aluno aluno = ListaAlunos.Find(x => x.Matricula == n);
            while(aluno == null)
            {
                Console.WriteLine("O aluno existe porém, seu matricula está incorreto");
                Console.Write("Digite novamente: ");
                n = Sonumeros(Console.ReadLine());
                aluno = ListaAlunos.Find(x => x.Matricula == n);
            }

            Console.Write("Digite o número do código da turma: ");
            n = Sonumeros(Console.ReadLine());
            Turma turma = Listaturma.Find(x => x.Codigo == n);
            while (turma == null)
            {
                Console.WriteLine("Turma existe porém seu codigo está incorreto");
                Console.Write("Digite novamente: ");
                n = Sonumeros(Console.ReadLine());
                turma = Listaturma.Find(x => x.Codigo == n);
            }
            if (turma.ListaAlunosAtribuidos.Count == turma.Tamanho)
            {
                Console.WriteLine("Essa turma está cheia");
            }
            else
            {
                Listaturma.Where(a => a.Codigo == n).FirstOrDefault().ListaAlunosAtribuidos.Add(aluno); // Adiciona o aluno encontrado na lista de Alunos dentro da turma selecionada
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
                turm.ExibirProfessor();      
        }
        public void MostrarFinalCoordenador()
        {
            foreach(Turma turm in Listaturma)
                turm.ExibirCoordenador();
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
                                  $" com o número de registro {prof.Registro}, Sendo como responsavel: O coordenador {prof.Responsavel.Nome} com o registro  {prof.Responsavel.Registro}");
        }

        public void MostrarCoordenador()
        {
            foreach (Coordenador cor in ListaCoordenador)
                Console.WriteLine($"Coordenadores {cor.Nome} do sexo {cor.Sexo} com a idade {cor.Idade}, " +
                                  $" com o número de registro {cor.Registro}");
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
                Console.WriteLine();
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
