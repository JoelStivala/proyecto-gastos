using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Repositories.GastoRepository
{
    public interface IGastoRepository
    {
        Task<List<Gasto>> GetAllAsync();
        Task<Gasto?> GetByIdAsync(int id);
        Task<Gasto> CreateAsync(Gasto gasto);
        Task<Gasto?> DeleteAsync(int id);
    }
}