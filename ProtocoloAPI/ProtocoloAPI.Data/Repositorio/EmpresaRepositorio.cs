using ProtocoloAPI.Data.Repositorio.Interface;
using ProtocoloAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocoloAPI.Data.Repositorio
{
    public class EmpresaRepositorio : GenericRepositorio<Empresa>, IEmpresaRepositorio
    {
        public IEnumerable<Empresa> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
