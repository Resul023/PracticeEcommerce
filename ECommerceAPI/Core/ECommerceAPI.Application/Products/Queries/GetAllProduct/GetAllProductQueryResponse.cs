namespace ECommerceAPI.Application.Products.Queries.GetAllProduct;
public class GetAllProductQueryResponse
{
    public int TotalProductCount { get; set; }
    public IEnumerable<ProductGetDto> Products { get; set; }
}

