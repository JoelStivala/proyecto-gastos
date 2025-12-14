using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.DTOs.GastoDTOs;

namespace backend.Mappers
{
    public static class GastoMappers
    {
        public static GetGastoDTO ToGastoDTO(this Gasto gasto)
        {
            return new GetGastoDTO
            {
                Id = gasto.Id,
                Descripcion = gasto.Descripcion,
                Importe = gasto.Importe
            };
        }

        public static Gasto ToGastoFromCreateDTO(this CreateGastoDTO createDTO)
        {
            return new Gasto
            {
                Descripcion = createDTO.Descripcion,
                Importe = createDTO.Importe
            };
        } 
    }
}