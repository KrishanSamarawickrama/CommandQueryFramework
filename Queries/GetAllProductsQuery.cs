using CommandQueryFramework.Models;
using MediatR;

namespace CommandQueryFramework.Queries;

public sealed class GetAllProductsQuery: IRequest<IEnumerable<Product>>
{
}