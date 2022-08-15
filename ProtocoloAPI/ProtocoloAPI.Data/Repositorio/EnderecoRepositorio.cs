using ProtocoloAPI.Data.Repositorio.Interface;
using ProtocoloAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocoloAPI.Data.Repositorio
{
    public class EnderecoRepositorio : GenericRepositorio<Endereco>, IEnderecoRepositorio
    {
        public IEnumerable<Endereco> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
