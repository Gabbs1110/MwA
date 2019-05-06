using Mwa.Domain.Comand.Results;
using Mwa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mwa.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IEnumerable<GetProductListCommandResult> Get();
        
    }
}
