using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;
using Microsoft.EntityFrameworkCore;
using WebTest.Services.Exceptions;

namespace WebTest.Services
{
    public class SellerService
    {
        private readonly WebTestContext _context;

        public SellerService(WebTestContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
            //acessa a fonte de dados de Vendedores
            //e converte para uma lista
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            //include para dar JOIN de chave estrangeira e mostrar Departamento ID
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync(); //remocao de seller
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Seller has sales");
            }
        }

        public async Task UpdateAsync (Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny) //existe no BD?
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
