using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs.GastoDTOs
{
    public class CreateGastoDTO
    {
        public string Descripcion { get; set; } = string.Empty;
        public decimal Importe { get; set; }
    }
}