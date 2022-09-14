using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenvolvimentoGuiadoTeste
{
    public class Funcionario
    {
        public int codigoFuncionario { get; set; }
        public string nomeFuncionario { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public int cep { get; set; }
        public string email { get; set; }
        public double salario { get; set; }

        public Funcionario(){}

        public Funcionario(int codigoFuncionario, string nomeFuncionario, string endereco, string cidade, int cep, string email, double salario)
        {
            this.codigoFuncionario = codigoFuncionario;
            this.nomeFuncionario = nomeFuncionario;
            this.endereco = endereco;
            this.cidade = cidade;
            this.cep = cep;
            this.email = email;
            this.salario = salario;
        }

        public double CalcularHorasExtras(Funcionario funcionario, double horasExtras)
        {
            double salario = ((funcionario.salario + ((funcionario.salario / 220) * horasExtras)) * 0.85);
            return salario;
        }
    }
}
