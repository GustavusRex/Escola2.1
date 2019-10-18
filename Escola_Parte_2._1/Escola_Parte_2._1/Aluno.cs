using System;


namespace Escola_Parte_2._1
{
    class Aluno : Pessoa // Classe onde guarda as caracteriscas de Aluno e herdado de pessoa
    {
        public int Matricula;
        public string Bolsista;

        public void ColoqueAsInformacaosAlunos() 
        {
            Random random = new Random(); // Ramdom para gerar uma matricula aleatoria
            Matricula = random.Next(10000000);

         
            Nome = SoLetras2(Console.ReadLine()); // Chama o metodo para a validação do nome escrito em Aluno

            Console.WriteLine($"\nDigite o sexo (M = Masculino ou F = Feminino) do(a) Aluno(a) {Nome}");

            Sexo = ValidarSexo(Console.ReadLine().ToUpper()); // Chama o metodo para a validação do sexo escrito em Aluno

            Console.WriteLine($"\nDigite a idade (Idade tem que ser maior que 2) do(a) Aluno(a) {Nome} ");

            Idade = ValidarIdadeA(Console.ReadLine()); // Chama o metodo para validar a idade em Aluno

            Console.WriteLine("\nO Aluno é bolsista? <S> para Sim e <N> para Não");
            Bolsista = Console.ReadLine().ToUpper();

            while (Bolsista != "S" && Bolsista != "N")
            {

                Console.WriteLine("Opção invalida porfavor digitar (S) para sim e (N) para não");
                Bolsista = Console.ReadLine().ToUpper();
            }

        }


    }
}