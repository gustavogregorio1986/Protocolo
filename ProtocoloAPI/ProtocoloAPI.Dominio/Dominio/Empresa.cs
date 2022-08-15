using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProtocoloAPI.Dominio.Dominio
{
    [Table("tb_Empresa")]
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        public string NomeEmpresa { get; set; }

        public string Cpnj { get; set; }

        public int NumFuncionario { get; set; }

        public Protocolo Protocolo { get; set; }

        [ForeignKey("Protocolo")]
        public int Id_Protocolo { get; set; }
    }
}
