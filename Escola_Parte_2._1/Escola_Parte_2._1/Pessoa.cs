
using System;
using System.Text.RegularExpressions;


namespace Escola_Parte_2._1
{
    abstract class Pessoa
    {
        public string Nome;
        public string Sexo;
        public byte Idade = 0;

        public string SoLetras2(string s) // Metodo para checar se existe algum caracter que não seja uma letra
        {
            while ((!Regex.IsMatch(s, @"^[a-zA-Z]+$")) || (s.Length < 3))
            {
                Console.WriteLine("Nome invalido, digite novamente sem espaços, caracteres, numero e maior qe trêS caracteres ");
                s = Console.ReadLine();

            }
            return s;
        }

        public string ValidarSexo(string s) // Metodo para validar se a condição do Sexo é aceita
        {
            while (s != "M" && s != "F")
            {
                Console.WriteLine("Sexo invalido, digite apenas M para Masculino e F para Feminino");
                s = Console.ReadLine().ToUpper();
            }
            return s;
        }

        public byte ValidarIdadeP(string s)
        {
            byte n;
            while((!byte.TryParse(s, out n)) || (n <= 21 || n >= 80))
            {
                Console.WriteLine("Um professor deve ter no mínimo 22 anos e no máximo 79");
                Console.WriteLine("por favor digitar novamente com um número inteiro e valido\n");
                s = Console.ReadLine();
            }
            return n;

        }
        public byte ValidarIdadeA(string s)
        {
            byte n;
            while ((!byte.TryParse(s, out n)) || (n <= 2))
            {
                Console.WriteLine("Um aluno deve ter no mínimo 3 anos ");
                Console.WriteLine("por favor digitar novamente com um número inteiro e valido\n");
                s = Console.ReadLine();
            }
            return n;

        } 

    }
}