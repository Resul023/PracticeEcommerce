using ECommerceAPI.Application.Common.Interfaces;

namespace ECommerceAPI.Application.Products.Queries.GetByIdProduct;

public class GetByIdProductQueryResponse:IMapFrom<Product>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}
