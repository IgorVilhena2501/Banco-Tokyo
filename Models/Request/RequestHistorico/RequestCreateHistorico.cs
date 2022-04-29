using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestHistorico
{
    public class RequestCreateHistorico
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public int CPF { get; }
        public string MeuNome { get; }
        public string MeuSobrenome { get; }
        public int MeuId { get; }
        public DateTime Data { get; }
        public double Valor { get; }

        public RequestCreateHistorico(string nome, string sobrenome, int cpf, string meunome, string meusobrenome, int meuid, DateTime data, double valor)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            MeuNome = meunome;
            MeuSobrenome = meusobrenome;
            MeuId = meuid;
            Data = data;
            Valor = valor;
        }
    }
}
