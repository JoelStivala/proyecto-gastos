using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories.GastoRepository
{
    public class GastoRepository : IGastoRepository
    {
        private readonly AppDbContext _context;

        public GastoRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Gasto>> GetAllAsync()
        {
            return await _context.Gastos.ToListAsync();
        }
        
        public async Task<Gasto?> GetByIdAsync(int id)
        {
            return await _context.Gastos.FindAsync(id);
        }

        public async Task<Gasto> CreateAsync(Gasto gasto)
        {
            await _context.AddAsync(gasto);
            await _context.SaveChangesAsync();

            return gasto;
        }

        public async Task<Gasto?> DeleteAsync(int id)
        {
            var gasto = await _context.Gastos.FirstOrDefaultAsync(g => g.Id == id);

            if(gasto == null)
                return null;

            _context.Gastos.Remove(gasto);
            await _context.SaveChangesAsync();

            return gasto;
        }
    }
}