using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestCliente
{
    public abstract class RequestSearchCliente
    {
    }
    public class RequestSearchClienteByNome : RequestSearchCliente
    {
        public string Name { get;}
        public RequestSearchClienteByNome(string name)
        {
            Name = name;
        }
    }
    public class RequestSearchClienteBySobrenome : RequestSearchCliente
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public RequestSearchClienteBySobrenome(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
    public class RequestSearchClienteByCPF : RequestSearchCliente
    {
        public int CPF { get;}
        public RequestSearchClienteByCPF(int cpf)
        {
            CPF = cpf;
        }
    }
    public class RequestSearchClienteById : RequestSearchCliente
    {
        public int Id { get; }
        public RequestSearchClienteById(int id)
        {
            Id = id;
        }
    }
    public class RequestSearchClienteBySenha : RequestSearchCliente
    {
        public string Senha { get; }
        public RequestSearchClienteBySenha(string senha)
        {
            Senha = senha;
        }
    }
}
