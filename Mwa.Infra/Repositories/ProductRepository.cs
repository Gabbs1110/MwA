using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Mwa.Domain.Comand.Results;
using Mwa.Domain.Entities;
using Mwa.Domain.Repositories;
using Mwa.Infra.Contexts;

namespace Mwa.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MwaDataContext _context;


        public ProductRepository(MwaDataContext context)
        {
            _context = context;
        }
        



        public Product Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetProductListCommandResult> Get()
        {
            return _context.Connection
            .Query<GetProductListCommandResult>(
            "getProduct", new {},
            transaction: _context._transaction,
            commandType: CommandType.StoredProcedure);
        }
    }
}