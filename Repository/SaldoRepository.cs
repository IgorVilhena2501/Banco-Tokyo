using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Banco_Toyko.Models.Entidades;
using Banco_Toyko.Models.Request.RequestSaldo;
using Banco_Toyko.Models.Response;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Repository.SalodRepository
{
    public class SaldoRepository : BaseRepository
    {
        public GenericResponse<Saldo> CreateSaldo(RequestCreateSaldo request)
        {
            try
            {
                var Retorno = new Saldo()
                {
                    Id = request.Id,
                    Valor = request.Valor
                };

                string SQL = @"INSERT INTO Saldo VALUES(@Id,@Valor)";

                connection.Execute(SQL, new { request.Id, request.Valor });

                return new GenericResponse<Saldo>("Tudo certo", false, Retorno);
            }
            catch (Exception ex)
            {
                return new GenericResponse<Saldo>("Erro", false, null);
            }
        }
        public double ReadSaldo(RequestReadSaldo request)
        {
            try
            {
                var SQL = "Select SUM(Saldo) From Saldo Where Id = @Id";

                var retorno = connection.Query<double>(SQL, param: new { request.Id }).FirstOrDefault();

                return retorno;
            }
            catch (Exception ex)
            {
                return 50.123456789;
            }
        }
        public double GastosPositivos(RequestReadSaldo request)
        {
            try
            {
                var SQLMais = "SELECT Saldo FROM Saldo Where Saldo > 0 AND Id = @Id;";

                return connection.Query<double>(SQLMais, param: new { request.Id }).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return 0.3876346534;
            }
        }
        public double GastosNegativos(RequestReadSaldo request)
        {
            try
            {
                var SQLMenos = "SELECT Saldo FROM Saldo Where Saldo < 0 AND Id = @Id;";

                return connection.Query<double>(SQLMenos , param: new { request.Id }).FirstOrDefault();

            }
            catch (Exception ex)
            {
                return 0.3876346534;
            }
        }
    }
}
