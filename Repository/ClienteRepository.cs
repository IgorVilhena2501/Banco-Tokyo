using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Banco_Toyko.Models.Entidades;
using Banco_Toyko.Models.Request.RequestCliente;
using Banco_Toyko.Models.Response;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Repository.ClienteRepository
{
    public class ClienteRepository : BaseRepository
    {
        public GenericResponse<Cliente> CreateCliente(RequestCreateCliente request)
        {
            try
            {
                string SQLVerificar = "SELECT * FROM Cliente WHERE Senha = @Senha";

                var Verificar = connection.Query<Cliente>(SQLVerificar, param: new { request.Senha }).ToList();

                if(Verificar == null)
                {
                    return new GenericResponse<Cliente>("Não pode ter duas contas com a mesma senha", false, null); 
                }

                var Retorno = new Cliente()
                {
                    Identificador = request.Identificador,
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
                    CPF = request.CPF,
                    Idade = request.Idade,
                    Senha = request.Senha
                };

                string SQLCreate = @"INSERT INTO Cliente VALUES(@Identificador, @Nome, @Sobrenome, @CPF, @Idade, @Senha)";

                connection.Execute(SQLCreate, param: new { Identificador = request.Identificador, Nome = request.Nome, Sobrenome = request.Sobrenome, CPF = request.CPF, Idade = request.Idade, Senha = request.Senha });

                return new GenericResponse<Cliente>("Tudo certo", true, Retorno);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public GenericListResponse<Cliente> SearchCliente(RequestSearchClienteByCPF request)
        {
            try
            {
                string SQL = @"SELECT * FROM Cliente WHERE CPF Like@CPF%";

                var retorno = connection.Query<Cliente>(SQL, param: new { request.CPF }).ToList();

                return new GenericListResponse<Cliente>("Tudo certo", true, retorno);
            }
            catch (Exception ex)
            {
                return new GenericListResponse<Cliente>("Erro", false, null);
            }
        }
        public GenericResponse<Cliente> SearchClienteById(RequestSearchClienteById request)
        {
            try
            {
                string SQL = @"SELECT * FROM Cliente WHERE Identificador = @Id";

                var retorno = connection.Query<Cliente>(SQL, param: new { request.Id }).FirstOrDefault();

                return new GenericResponse<Cliente>("Tudo certo", true, retorno);
            }
            catch (Exception ex)
            {
                return new GenericResponse<Cliente>("Erro", false, null);
            }
        }
        public GenericResponse<Cliente> SearchClienteBySenha(RequestSearchClienteBySenha request)
        {
            try
            {
                string SQL = @"SELECT * FROM Cliente WHERE Senha = @Senha";

                var retorno = connection.Query<Cliente>(SQL, param: new { Senha = request.Senha }).FirstOrDefault();

                return new GenericResponse<Cliente>("Tudo certo", true, retorno);
            }
            catch (Exception ex)
            {
                return new GenericResponse<Cliente>("Erro", false, null);
            }
        }
        public bool LogCliente(RequestLoginCliente request)
        {
            try
            {
                string SQL = "SELECT * FROM Cliente WHERE Senha = @Senha AND Nome = @Nome";

                var Retorno = connection.Query<Cliente>(SQL, param: new { request.Senha, request.Nome }).FirstOrDefault();


                if(Retorno == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
