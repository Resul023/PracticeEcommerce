namespace ECommerceAPI.Application.Products.Queries.GetByIdProduct;
public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
{
    public Guid Id { get; set; } 
}
