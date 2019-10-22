using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class NovoMenu : Validacoes
    {
        Escola escola = new Escola();
        public void MenuEscola()
        {
            int opcao;
            int opcao2;
            int opcao3;
            int opcao4;
            int opcao5;
            do
            {
                Console.Clear();
                Console.WriteLine("---------------MENU DA ESCOLA---------------");
                Console.WriteLine("\nDigite 1 para os Cadastros");
                Console.WriteLine("Digite 2 para mostrar as Listas");
                Console.WriteLine("Digite 3 para as Atribuições");
                Console.WriteLine("Digite 4 para as Remoções");
                Console.WriteLine("Digite 0 para sair do menu");

                opcao = Sonumeros(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------Menu de Cadastros---------------");
                                Console.WriteLine("\nDigite 1 para cadastrar as turmas");
                                Console.WriteLine("Digite 2 para cadastrar os alunos");
                                Console.WriteLine("Digite 3 para cadastrar os professores(Lembre-se é necessário um coordenador antes)");
                                Console.WriteLine("Digite 4 para cadastrar os coordenadores");
                                Console.WriteLine("Digite 0 para voltar ao menu principal");

                                opcao2 = Sonumeros(Console.ReadLine());
                                switch (opcao2)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cadastrar turmas selecionado\n");
                                            escola.ListaDeTurmas();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cadastrar alunos selecionado\n");
                                            escola.ListaDeAlunos();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cadastrar professores selecionado\n");
                                            escola.ListaDeProfessores();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cadastrar coordenadores selecionado");
                                            escola.ListaDeCoordenadores();
                                            break;
                                        }
                                }

                            } while (opcao2 != 0);
                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------Menu de Exibição---------------");
                                Console.WriteLine("\nDigite 1 para exibir as turmas em geral");
                                Console.WriteLine("Digite 2 para exibir os alunos cadastrados em espera");
                                Console.WriteLine("Digite 3 para exibir os professores cadastrados disponiveis");
                                Console.WriteLine("Digite 4 para exibir os coordenadores cadastrados");
                                Console.WriteLine("Digite 5 para exibir as turmas as atribuições");
                                Console.WriteLine("Digite 0 para voltar ao menu principal");
                                opcao3 = Sonumeros2(Console.ReadLine());
                                switch (opcao3)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nMostrar turma selecionado!");
                                            if (escola.Listaturma.Count == 0)

                                                Console.WriteLine("\nNão há turmas cadastradas\n");

                                            escola.MostrarTurmas();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nMostrar alunos escolhido!");
                                            if (escola.ListaAlunos.Count == 0)

                                                Console.WriteLine("\nNão há alunos cadastradas\n");

                                            escola.MostrarAlunos();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nMostrar professor escolhido!");
                                            if (escola.ListaProfessor.Count == 0)

                                                Console.WriteLine("\nNão há professores cadastrados\n");

                                            escola.MostrarProfessor();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\nMostrar professor escolhido!");
                                            if (escola.ListaCoordenador.Count == 0)
                                                Console.WriteLine("\nNão há Coordenadores cadastrados\n");

                                            escola.MostrarCoordenador();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            escola.MostrarTutto();
                                            Console.ReadKey();
                                            break;
                                        }
                                }

                            } while (opcao3 != 0);
                            break;
                        }
                    case 3:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------Menu de Atribuição---------------");
                                Console.WriteLine("\nDigite 1 para atribuir um coordenador a turma");
                                Console.WriteLine("Digite 2 para atribuir um professor a turma");
                                Console.WriteLine("Digite 3 para atribuir alunos a turma");
                                Console.WriteLine("Digite 0 para voltar ao menu principal");
                                opcao4 = Sonumeros3(Console.ReadLine());
                                switch (opcao4)
                                {
                                    case 1:
                                        {
                                            Console.Clear();

                                            if (escola.Listaturma.Count == 0)
                                            {
                                                Console.WriteLine("\nNão é possível atribuir um coordenador a turma, pois não há turmas cadastradas");
                                                Console.WriteLine("Deseja criar uma turma para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla para sim e aperte ESC para não");
                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar turmas selecionado");
                                                    escola.ListaDeTurmas();
                                                }
                                            }
    
                                            if (escola.ListaCoordenador.Count == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nNão é possível atribuir um coordenador a turma, pois não há coordenadores cadastrados");
                                                Console.WriteLine("Deseja cadastrar um coordenador para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla para sim e aperte ESC para não");
                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar coordenador selecionado");
                                                    escola.ListaDeCoordenadores();
                                                }
                                            }
                                            Console.Clear();
                                            Console.WriteLine("Atribuir coordenador selecionado");
                                            Console.WriteLine("Turmas: ");
                                            escola.MostrarTurmas();
                                            Console.WriteLine("\nCoordenadores Disponíveis" );
                                            escola.MostrarCoordenador();
                                            Console.WriteLine();
                                            escola.AddCoordenadorTurma();
                                            escola.MostrarFinalCoordenador();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();

                                            if (escola.Listaturma.Count == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nNão é possível atribuir um professor a turma, pois não há turmas cadastradas");
                                                Console.WriteLine("Deseja criar uma turma para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla para sim e aperte ESC para não");
                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar turmas selecionado");
                                                    escola.ListaDeTurmas();
                                                }
                                            }
                                            
                                            if (escola.ListaProfessor.Count == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nNão é possível atribuir um professor a turma, pois não há professores diponiveis cadastrados");
                                                Console.WriteLine("Deseja cadastrar um professor para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla para sim e aperte ESC para não");
                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar professor selecionado");
                                                    escola.ListaDeProfessores();
                                                }
                                            }

                                            Console.Clear();
                                            Console.WriteLine("Atribuir professor selecionado");
                                            Console.WriteLine("Turmas: ");
                                            escola.MostrarTurmas();
                                            Console.WriteLine("\nProfessores disponíveis: ");
                                            escola.MostrarProfessor();
                                            Console.WriteLine();
                                            escola.AddProfessorTurma();
                                            escola.MostrarFinalProfessor();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {

                                            Console.Clear();
                                            if (escola.Listaturma.Count == 0)
                                            {
                                                Console.WriteLine("\nNão é possível atribuir um professor a turma, pois não há turmas cadastradas");
                                                Console.WriteLine("Deseja criar uma turma para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla para sim e aperte ESC para não");
                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar turmas selecionado");
                                                    escola.ListaDeTurmas();
                                                }
                                            }
                                            
                                            if (escola.ListaAlunos.Count == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nNão é possível atribuir um aluno a turma, pois não há alunos diponiveis cadastrados");
                                                Console.WriteLine("Deseja cadastrar um professor para continuar?");
                                                Console.WriteLine("Aperte Qualquer tecla sim e aperte ESC para não");

                                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                                {
                                                    opcao4 = 0;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Cadastrar alunos selecionado");
                                                    escola.ListaDeAlunos();
                                                }
                                            }

                                            Console.Clear();
                                            Console.WriteLine("Atribuir aluno selecionado");
                                            Console.WriteLine("Turmas: ");
                                            escola.MostrarTurmas();
                                            Console.WriteLine("\nAlunos Disponíveis: ");
                                            escola.MostrarAlunos();
                                            Console.WriteLine();
                                            escola.AddAlunosTurma();
                                            escola.MostrarFinalAluno();
                                            Console.ReadKey();
                                            break;

                                        }
                                }
                            } while (opcao4 != 0);
                            break;
                        }
                    case 4:
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------Menu de Remoção---------------");
                                Console.WriteLine("\nDigite 1 para remover um coordenador a turma");
                                Console.WriteLine("Digite 2 para remover um professor a turma");
                                Console.WriteLine("Digite 3 para remover alunos a turma");
                                Console.WriteLine("Digite 0 para voltar ao menu principal");
                                opcao5 = Sonumeros3(Console.ReadLine());
                                switch (opcao5)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Remover coordenador selecionado");
                                            escola.MostrarFinalCoordenador();
                                            Console.WriteLine();
                                            escola.RemoveCoordenador();
                                            Console.WriteLine();
                                            escola.MostrarFinalCoordenador();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Remover professor selecionado");
                                            escola.MostrarFinalProfessor();
                                            Console.WriteLine();
                                            escola.RemoveProfessor();
                                            Console.WriteLine();
                                            escola.MostrarFinalProfessor();
                                            Console.ReadKey();
                                            break;

                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Remover aluno selecionado");
                                            escola.MostrarFinalAluno();
                                            Console.WriteLine();
                                            escola.RemoveAluno();
                                            Console.WriteLine();
                                            escola.MostrarFinalAluno();
                                            Console.ReadKey();
                                            break;
                                        }
                                }

                            } while (opcao5 != 0);
                            break;
                        }

                }
            } while (opcao != 0);
        }

    }
}
