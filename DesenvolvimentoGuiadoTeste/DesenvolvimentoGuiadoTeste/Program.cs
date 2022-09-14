using System;

namespace DesenvolvimentoGuiadoTeste
{
    class Program
    {
        public static void Main(string[] args)
        {
            int qtdHorasExtras;
            double total;
            Funcionario novoFuncionario = new Funcionario();
            Console.WriteLine("Bem vindo ao calculo de salario liquido");
            Console.Write("por favor insira seu codio ");
            novoFuncionario.codigoFuncionario = Convert.ToInt32(Console.ReadLine());
            Console.Write("por favor insira seu nome: ");
            novoFuncionario.nomeFuncionario = Console.ReadLine();
            Console.Write("por favor insira o seu endereco:");
            novoFuncionario.endereco = Console.ReadLine();
            Console.Write("por favor insira a sua cidade:");
            novoFuncionario.cidade = Console.ReadLine();
            Console.Write("por favor insira o seu CEP:");
            novoFuncionario.cep = Convert.ToInt32(Console.ReadLine());
            Console.Write("por favor insira o seu E-mail:");
            novoFuncionario.email = Console.ReadLine();
            Console.Write("por favor insira o seu salario base:");
            novoFuncionario.salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("por favor insira a quantidade de horas extras:");
            qtdHorasExtras = Convert.ToInt32(Console.ReadLine());

            total = novoFuncionario.CalcularHorasExtras(novoFuncionario, qtdHorasExtras);
            Console.WriteLine("o total que será recebido por este funcionario é: " + total);

        }
    }
}
