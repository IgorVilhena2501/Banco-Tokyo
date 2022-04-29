using Banco_Toyko.Models.Entidades;
using Banco_Toyko.Models.Models;

namespace Banco_Toyko.Models
{
    public class ClienteLoged
    {
        public static Cliente cliente = new Cliente();

        public static Cliente Get()
        {
            return cliente;
        }
        public static void Set(Cliente request)
        {
            cliente = request;
        }
    }
}
