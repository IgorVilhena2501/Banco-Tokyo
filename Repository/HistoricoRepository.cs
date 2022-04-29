using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Banco_Toyko.Models.Entidades;
using Banco_Toyko.Models.Request.RequestHistorico;
using Banco_Toyko.Models.Response;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Repository.HistoricoRepository
{
    public class HistoricoRepository : BaseRepository
    {
        public GenericResponse<Historico> CreateHistorico(RequestCreateHistorico request)
        {
            try
            {
                var Retorno = new Historico()
                {
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
                    CPF = request.CPF,
                    MeuNome = request.MeuNome,
                    MeuSobrenome = request.MeuSobrenome,
                    MeuId = request.MeuId,
                    Data = request.Data,
                    Valor = request.Valor
                };

                string SQL = @"INSERT INTO Historico VALUES(@Nome, @Sobrenome, @CPF, @MeuNome, @MeuSobrenome, @MeuId ,@Data, @Valor)";

                connection.Execute(SQL, new { Nome = request.Nome, Sobrenome = request.Sobrenome, request.CPF, request.MeuNome, request.MeuSobrenome, request.MeuId ,request.Data, request.Valor });

                return new GenericResponse<Historico>("Tudo certo", false, Retorno);
            }catch(Exception ex)
            {
                return new GenericResponse<Historico>("Erro", false, null);
            }
        }
        public GenericListResponse<Historico> ReadHistorico(RequestReadHistorico request)
        {
            try
            {
                string SQL = @"SELECT * FROM Historico WHERE MeuId = @Id";

                var Retorno = connection.Query<Historico>(SQL, param: new { request.Id }).ToList();

                return new GenericListResponse<Historico>("Tudo certo", true, Retorno);
            }
            catch (Exception)
            {
                return new GenericListResponse<Historico>("Erro", false, null);
            }
        }
    }
}
