using System;


namespace Escola_Parte_2._1
{
    class Menu
    {
        Escola escola = new Escola();

        public void Menyu()
        {
            int opcao;
            string validar;
            string opcao2;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Para Cadastro Escolar\n");
                Console.WriteLine("Digite 1 para cadastrar as turmas");
                Console.WriteLine("Digite 2 para cadastrar os alunos");
                Console.WriteLine("Digite 3 para cadastrar os professores");
                Console.WriteLine("Digite 4 para mostrar as turmas");
                Console.WriteLine("Digite 5 para mostrar os alunos");
                Console.WriteLine("Digite 6 para mostrar os professores");
                Console.WriteLine("Digite 7 para inserir alunos a turma");
                Console.WriteLine("Digite 8 para inserir professor a turma");
                Console.WriteLine("Digite 9 para mostrar todas as turmas já cadastradas");
                Console.WriteLine("Digite 0 para sair do cadastro\n");

                opcao = Sonumeros(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Cadastrar turmas selecionado!\n");
                            Console.WriteLine("Digite 0 para cancelar (Somente nessa parte)");
                            escola.ListaDeTurmas(); // Metodo para cadastrar uma lista de turmas
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar alunos selecionado!\n");
                            Console.WriteLine("Digite 0 para cancelar (Somente nessa parte)");
                            escola.ListaDeAlunos(); // Metodo para cadastrar uma lista de Alunos                           
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\nCadastrar professor selecionado!\n");
                            Console.WriteLine("Digite 0 para cancelar (Somente nessa parte)");
                            escola.ListaDeProfessores(); //  Metodo para cadastrar a lista de Professores
                           
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar turma selecionado!");
                            if(escola.Listaturma.Count == 0)
                            
                                Console.WriteLine("\nNão há turmas cadastradas\n");
                            
                            escola.MostrarTurmas();
                            break;
                        }

                    case 5:

                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar alunos escolhido!");
                            if (escola.ListaAlunos.Count == 0)
                            
                                Console.WriteLine("\nNão há alunos cadastradas\n");
                            
                            escola.MostrarAlunos();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("\nMostrar professor escolhido!");
                            if (escola.ListaProfessor.Count == 0)
                            
                                Console.WriteLine("\nNão há professores cadastradas\n");
                            
                            escola.MostrarProfessor();
                            break;

                        }
                    case 7:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Atribuir Aluno a uma turma selecionado\n");


                               
                                if (escola.Listaturma.Count == 0)
                                {
                                    Console.WriteLine("Não existe turmas cadastradas");
                                }

                                Console.WriteLine("\nOs alunos cadastrados são: ");
                                if (escola.ListaAlunos.Count == 0)
                                {
                                    Console.WriteLine("Não existe alunos cadastrados");
                                }
                                escola.MostrarAlunos();

                                Console.WriteLine("As Turmas Disponiveis: ");
                                if (escola.Listaturma.Count == 0)
                                {
                                    Console.WriteLine("Não existe turmas cadastradas");
                                }
                                escola.MostrarTurmas();

                                Console.WriteLine("\nSub-menu Alunos (Caso queira cadastrar daqui)");
                                Console.WriteLine("Digite 1 para cadastrar as turmas");
                                Console.WriteLine("Digite 2 para cadastrar os alunos");
                                Console.WriteLine("Digite 0 para sair do sub-menu e ir para atribuição");
                                validar = Console.ReadLine();

                                while (!int.TryParse(validar, out opcao))
                                {
                                    Console.WriteLine("Digite um número para opcão");
                                    validar = Console.ReadLine();
                                }

                                switch (opcao)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Cadastrar turmas selecionado!\n");
                                        escola.ListaDeTurmas();
                                        break;

                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\nCadastrar alunos selecionado!\n");
                                        escola.ListaDeAlunos();
                                        break;
                                    default:

                                        break;

                                }
                                Console.WriteLine("Deseja volta para sub-menu ? Se Sim digite (S) e se Não digite (N)");
                                validar = Console.ReadLine().ToUpper();
                            } while (validar == "S");


                            Console.Clear();
                            Console.WriteLine("Os alunos cadastrados são: ");
                            escola.MostrarAlunos();

                            Console.WriteLine("As Turmas Disponiveis: ");
                            escola.MostrarTurmas();

                            Console.WriteLine("\nInserir Alunos dentro a uma turma!\n");
                            escola.AddAlunosTurma();
                            Console.WriteLine();

                            escola.MostrarFinalAluno(); // Mostrar professor dentro da turma

                            break;
                        }
                    case 8:
                        {
                            do 
                            { 
                                Console.Clear();
                                Console.WriteLine("Atribuir Professor a uma turma selecionado");
                            
                                if (escola.ListaProfessor.Count == 0)
                                {
                                    Console.WriteLine("Não existe professores cadastrados");
                                }
                                if (escola.Listaturma.Count == 0)
                                {
                                    Console.WriteLine("Não existe turmas cadastradas");
                                }

                                Console.WriteLine("\bOs professores cadastrados são: ");

                                if (escola.ListaProfessor.Count == 0)
                                {
                                    Console.WriteLine("Não existe professores cadastrados");
                                }
                                escola.MostrarProfessor();

                                Console.WriteLine("As Turmas Disponiveis: ");
                                if (escola.Listaturma.Count == 0)
                                {
                                    Console.WriteLine("Não existe turmas cadastradas");
                                }                                                                                                                                                                                                                                
                                escola.MostrarTurmas();

                                Console.WriteLine("\nSub-menu Professor (caso queira cadastrar daqui)");
                                Console.WriteLine("Digite 1 para cadastrar as turmas");
                                Console.WriteLine("Digite 2 para cadastrar os professores");
                                Console.WriteLine("Digite 0 para sair do sub-menu e ir para atribuição");

                                validar = Console.ReadLine();
                                while (!int.TryParse(validar, out opcao))
                                {
                                    Console.WriteLine("Digite um número para opcão");
                                    validar = Console.ReadLine();
                                }


                                switch (opcao)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cadastrar turmas escolhido!\n");
                                            escola.ListaDeTurmas();
                                            if (escola.ListaProfessor.Count == 0)
                                            {
                                                Console.WriteLine("Não existe professores cadastrados");
                                            }
                                            if (escola.Listaturma.Count == 0)
                                            {
                                                Console.WriteLine("Não existe turmas cadastradas");
                                            }
                                            break;
                                        }
                                    case 2:
                                        {

                                            Console.Clear();
                                            Console.WriteLine("\nCadastrar professores escolhido!\n");
                                            escola.ListaDeProfessores();
                                            if (escola.ListaProfessor.Count == 0)
                                            {
                                                Console.WriteLine("Não existe professores cadastrados");
                                            }
                                            if (escola.Listaturma.Count == 0)
                                            {
                                                Console.WriteLine("Não existe turmas cadastradas");
                                            }
                                            break;
                                        }

                                }

                               Console.WriteLine("Deseja volta para sub-menu? Se Sim digite (S) e se Não digite (N)");
                                validar = Console.ReadLine().ToUpper();
                            } while (validar == "S");


                            Console.Clear();
                            Console.WriteLine("Os professores cadastrados são: ");
                            escola.MostrarProfessor();

                            Console.WriteLine("As Turmas Disponiveis: ");
                            escola.MostrarTurmas(); 

                            Console.WriteLine("\nInserir Professor dentro a uma turma!\n");
                            escola.AddProfessorTurma();
                            Console.WriteLine();

                            
                            escola.MostrarFinalProfessor(); // Mostrar professores já dentro da turma

                            break;
                        }
                    case 9:
                        {
                            escola.MostrarTutto(); // Mostrar Professor e Alunos já cadastrados
                            break;

                        }


                }

                Console.WriteLine("Operação Concluída! Deseja volta? Digite S se sim e N para sair do Cadastro");
                opcao2 = Console.ReadLine().ToUpper();

            } while (opcao2 == "S");

            static int Sonumeros(string s)
            {
                int n;
                while ((!int.TryParse(s, out n)) || (n < 0 || n > 9))
                {
                    Console.WriteLine("Opção invalida");
                    s = Console.ReadLine();

                }
                return n;

            }
        }
    }

}

