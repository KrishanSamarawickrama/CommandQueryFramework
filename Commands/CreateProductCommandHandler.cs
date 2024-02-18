using CommandQueryFramework.Data;
using CommandQueryFramework.Models;
using MediatR;

namespace CommandQueryFramework.Commands;

public sealed class CreateProductCommandHandler(AppDbContext context) : IRequestHandler<CreateProductCommand, Product>
{
    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product { Name = request.Name, Price = request.Price };
        context.Products.Add(product);
        await context.SaveChangesAsync(cancellationToken);
        return product;
    }
}