using CasgemMediator.Dal;
using CasgemMediator.MediatorPattern.Queries;
using CasgemMediator.MediatorPattern.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CasgemMediator.MediatorPattern.Handler
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {       
        private readonly Context _context;

        public ProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetProductQueryResult
            {
                Brand = x.Brand,
                Category = x.Category,
                Name = x.Name,
                Price = x.Price,
                ProductId = x.ProductId,
                Stock = x.Stock

            }).AsNoTracking().ToListAsync();
        }
    }
}
