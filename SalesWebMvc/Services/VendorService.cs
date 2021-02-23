using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class VendorService
    {
        private readonly SalesWebMvcContext _context;

        public VendorService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendor> FindAll()
        {
            return _context.Vendor.ToList();
        }

        public void Insert(Vendor vendor)
        {
            _context.Add(vendor);
            _context.SaveChanges();
        }

        public Vendor FindById(int id)
        {
            return _context.Vendor.Find(id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendor.Find(id);
            _context.Vendor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Vendor vendor)
        {
            bool hasAny = _context.Vendor.Any(x => x.Id == vendor.Id);

            if (!hasAny)
            {
                throw new Exception("Id not found");
            }

            _context.Update(vendor);
            _context.SaveChanges();
        }
    }
}
