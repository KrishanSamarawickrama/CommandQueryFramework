using CommandQueryFramework.Models;
using MediatR;

namespace CommandQueryFramework.Commands;

public sealed class CreateProductCommand : IRequest<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}