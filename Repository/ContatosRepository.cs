using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Banco_Toyko.Models.Entidades;
using Banco_Toyko.Models.Request.RequestContatos;
using Banco_Toyko.Models.Response;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Repository.ContatosRepository
{
    public class ContatosRepository : BaseRepository
    {
        public GenericResponse<Contatos> CreateContato(RequestCreateContato request)
        {
            try
            {
                var Retorno = new Contatos()
                {
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
                    MyId = request.MyId,
                    Id = request.Id,
                    CPF = request.CPF,
                };

                string SQL = @"INSERT INTO Contatos VALUES(@MyId,@Nome,@Sobrenome,@CPF,@Id)";

                connection.Execute(SQL, param: new { request.MyId, request.Nome, request.Sobrenome, request.CPF, request.Id });

                return new GenericResponse<Contatos>("Tudo certo", true, Retorno);
            }
            catch (Exception)
            {
                return new GenericResponse<Contatos>("Erro", false, null);
            }
        }
        public GenericListResponse<Contatos> ReadContato(RequestReadContatos request)
        {
            try
            {
                string SQL = @"SELECT * FROM Contatos WHERE MyId = @MyId";

                var Retorno = connection.Query<Contatos>(SQL, param: new { request.Id }).ToList();

                return new GenericListResponse<Contatos>("Tudo certo", true, Retorno);
            }
            catch (Exception)
            {
                return new GenericListResponse<Contatos>("Erro", false, null);
            }
        }
    }
}
