using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebTest.Services
{
    public class SellerService
    {
        private readonly WebTestContext _context;

        public SellerService(WebTestContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
            //acessa a fonte de dados de Vendedores
            //e converte para uma lista
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            //include para dar JOIN de chave estrangeira e mostrar Departamento ID
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges(); //remocao de seller
        }
    }
}
