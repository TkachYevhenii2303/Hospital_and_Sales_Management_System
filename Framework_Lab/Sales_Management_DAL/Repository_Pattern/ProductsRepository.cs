﻿using Labs_EF.Repositories;
using Sales_Management_DAL.Context.Base_Context;
using Sales_Management_DAL.Entities;
using Sales_Management_DAL.Repository_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Repository_Pattern
{
    public class ProductsRepository : GenericRepository<Products>, IProductsRepository
    {
        private readonly SalesContext _context;

        public ProductsRepository(SalesContext context) : base(context)
        {
            _context = context;
        }
    }
}
