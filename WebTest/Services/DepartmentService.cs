using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebTest.Services
{
    public class DepartmentService
    {
        private readonly WebTestContext _context;

        public DepartmentService(WebTestContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
