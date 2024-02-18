using CommandQueryFramework.Data;
using CommandQueryFramework.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryFramework.Queries;

public sealed class GetAllProductsQueryHandler(AppDbContext context) : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await context.Products.ToListAsync(cancellationToken);
    }
}