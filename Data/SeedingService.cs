using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _Context;

        public SeedingService(SalesWebMvcContext context)
        {
            _Context = context;
        }

        public void Seed()
        {
            if (_Context.Department.Any() || _Context.Seller.Any() || _Context.SalesRecord.Any())
            {
                return;
            }


            Department d1 = new Department(new int(), "Computadores");
            Department d2 = new Department(new int(), "Eletronicos");
            Department d3 = new Department(new int(), "Roupas");
            Department d4 = new Department(new int(), "Sapatos");

            Seller s1 = new Seller(new int(), "Jonas", "vendas@emaiol.com", 1600.00, new DateTime(1976, 10, 1), d1);
            Seller s2 = new Seller(new int(), "Maria", "vendas@emaiol.com", 1600.00, new DateTime(1980, 1, 10), d2);
            Seller s3 = new Seller(new int(), "Pedro", "vendas@emaiol.com", 1600.00, new DateTime(1997, 10, 10), d3);
            Seller s4 = new Seller(new int(), "Joana", "vendas@emaiol.com", 1600.00, new DateTime(1990, 1, 1), d4);

            SalesRecord sr1 = new SalesRecord(new int(),new DateTime(2018, 9, 25), 15.00,SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 15.00, SaleStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 25.00, SaleStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 150.00, SaleStatus.Billed, s2);
            SalesRecord sr5 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 300.00, SaleStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 45.00, SaleStatus.Billed, s3);
            SalesRecord sr7 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 555.00, SaleStatus.Billed, s4);
            SalesRecord sr8 = new SalesRecord(new int(), new DateTime(2018, 9, 25), 689.00, SaleStatus.Billed, s4);

            _Context.Department.AddRange(d1, d2, d3, d4);
            _Context.Seller.AddRange(s1,s2,s3,s4);
            _Context.SalesRecord.AddRange(sr1,sr2,sr3,sr4,sr5,sr6,sr7,sr8);

            _Context.SaveChanges();

        }
    }
}
