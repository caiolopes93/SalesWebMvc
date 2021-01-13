using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _contex;

        public SellerService(SalesWebMvcContext context)
        {
            _contex = context;
        }

        public List<Seller> FindAll()
        {
            return _contex.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _contex.Department.First();
            _contex.Add(obj);
            _contex.SaveChanges();
        }
    }
}
