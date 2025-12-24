using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Observaciones { get; set; } = string.Empty;
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }

        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; } = null!;
    }
}