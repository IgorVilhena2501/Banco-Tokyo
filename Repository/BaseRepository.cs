using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Repository
{
    public class BaseRepository
    {
        protected SqlConnection connection = new SqlConnection("Server=dbdev.hysoft.com.br;Database=Troctrip;User Id=sa;Password=Selecttop10*from;");
    }
}
