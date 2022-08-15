using ProtocoloAPI.Data.Repositorio.Interface;
using ProtocoloAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocoloAPI.Data.Repositorio
{
    public class AdministradorRepositorio : GenericRepositorio<Administrador>, IAdministradorRepositorio
    {
        public IEnumerable<Administrador> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
