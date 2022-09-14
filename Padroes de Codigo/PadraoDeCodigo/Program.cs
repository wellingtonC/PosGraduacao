using System;

namespace PadraoDeCodigo
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region variables
            int firstNumber;
            int lastNumber;
            char logicalOperator;
            int result;
            #endregion
            
            Console.WriteLine("Bem vindo a calculadora");
            try 
            {
                #region input
                Console.Write("insira o numero inicial: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a operacao desejada \n + para opercao de soma \n - para subtracao \n * para multiplicacao \n" + " / para divisao");
                logicalOperator = Convert.ToChar(Console.ReadLine());
                Console.Write("insira o segundo numero: ");
                lastNumber = Convert.ToInt32(Console.ReadLine());
                #endregion

                switch (logicalOperator.ToString())
                {
                    case "+":
                        result = firstNumber + lastNumber;
                        break;
                    case "-":
                        result = firstNumber - lastNumber;
                        break;
                    case "*":
                        result = firstNumber * lastNumber;
                        break;
                    case "/":
                        result = firstNumber / lastNumber;
                        break;
                    default:
                        Console.WriteLine("operador logico nao identificado");
                        throw new Exception();
                }

                Console.WriteLine("O resultado da sua equacao é : " + result);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("Erro ao executar programa, segue o erro mostrado pelo programa \n" + ex); 
            }
        }
    }
}
