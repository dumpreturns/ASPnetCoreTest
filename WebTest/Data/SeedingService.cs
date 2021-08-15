using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;
using WebTest.Models.Enums;

namespace WebTest.Data
{
    public class SeedingService
    {
        private WebTestContext _context;

        public SeedingService(WebTestContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //se DB ja estiver populado, aborta
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Smartphones");
            Department d3 = new Department(3, "Tablets");
            Department d4 = new Department(4, "Clothes");

            Seller s1 = new Seller(1, "Alex Mason", "bob@gmail.com",
                new DateTime(1998, 1, 1), 3000.0, d1);
            Seller s2 = new Seller(2, "Tiffany Rose", "rose@gmail.com",
                new DateTime(1983, 11, 2), 5000.0, d4);
            Seller s3 = new Seller(3, "Ronald Wilson", "ronald@gmail.com",
                new DateTime(2000, 3, 2), 4000.0, d2);
            Seller s4 = new Seller(4, "Robert Oliver", "oliver@gmail.com",
                new DateTime(1970, 5, 7), 4500.0, d3);
            Seller s5 = new Seller(5, "Amanda Redfield", "amanda@gmail.com",
                new DateTime(2002, 4, 5), 2000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01, 02), 
                11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 11, 10),
                13000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 07, 11),
                16000.0, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 11, 02),
                6000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 12, 12),
                1000.0, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 10, 25),
                13000.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 07, 11),
                3000.0, SaleStatus.Canceled, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 09, 30),
                1000.0, SaleStatus.Canceled, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 11, 10),
                6000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9);

            _context.SaveChanges();
        }
    }
}
