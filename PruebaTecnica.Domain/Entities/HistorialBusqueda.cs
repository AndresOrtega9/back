using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.Entities
{
    public class HistorialBusqueda
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Fact { get; set; } = string.Empty;
        [Column(TypeName = "varchar(250)")]
        public string Query { get; set; } = string.Empty;
        [Column(TypeName = "varchar(max)")]
        public string Url { get; set; } = string.Empty;
        [Column(TypeName = "datetime")]
        public DateTime FechaConsulta { get; set; }
    }
}
