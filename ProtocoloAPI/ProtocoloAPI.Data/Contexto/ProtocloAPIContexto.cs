using Microsoft.EntityFrameworkCore;
using ProtocoloAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocoloAPI.Data.Contexto
{
    public class ProtocloAPIContexto : DbContext
    {

        public ProtocloAPIContexto()
        {

        }

        public ProtocloAPIContexto(DbContextOptions option)
            : base(option)
        {

        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Administrador> Adminitradores { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Protocolo> Protocolos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
