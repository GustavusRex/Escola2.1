using System;
using System.Collections.Generic;
using System.Text;

namespace Escola_Parte_2._1
{
    class Coordenador:Pessoa
    {

        public int Registro;
        public void ColoqueAsInformacaosCoordenador(Escola escola)
        {
            Random random = new Random(); // Ramdom para gerar uma matricula aleatoria
            Registro = random.Next(10000);

            // if (Console.ReadKey().Key == ConsoleKey.Escape) return false;

            Nome = SoLetras2(Console.ReadLine()); // Chama o metodo para a validação do nome escrito em professor

            Console.WriteLine($"\nDigite o sexo (M = Masculino ou F = Feminino) do(a) Coordenador(a) {Nome}");


            Sexo = ValidarSexo(Console.ReadLine().ToUpper()); // Chama o metodo para a validação do nome escrito em professor

            Console.WriteLine($"\nDigite a idade(Idade é preciso ser maior de 21 e menor que 80) do(a) Coordenador(a) {Nome}");

            Idade = ValidarIdadeP(Console.ReadLine()); //Chama o metodo para validar a idade em Aluno


        }
    }
}
