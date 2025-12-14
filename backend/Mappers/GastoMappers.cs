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
                Nombre = gasto.Nombre,
                Observaciones = gasto.Observaciones,
                Importe = gasto.Importe,
                Fecha = gasto.Fecha
            };
        }

        public static Gasto ToGastoFromCreateDTO(this CreateGastoDTO createDTO)
        {
            return new Gasto
            {
                Nombre = createDTO.Nombre,
                Observaciones = createDTO.Observaciones,
                Importe = createDTO.Importe,
                Fecha = createDTO.Fecha
            };
        } 
    }
}