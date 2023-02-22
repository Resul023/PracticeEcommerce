namespace ECommerceAPI.Application.Products.Commands.CreateProduct;
public class CreateProductCommandRequest: IRequest<Guid>
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}


