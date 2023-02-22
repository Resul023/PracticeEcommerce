namespace ECommerceAPI.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Guid>
{
    private readonly IProductWriteRepository _productWriteRepository;

    public CreateProductCommandHandler(IProductWriteRepository productWriteRepository)
    {
        this._productWriteRepository = productWriteRepository;
    }

    public async Task<Guid> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        Product product = new()
        {
            Name = request.Name,
            Price = request.Price,
            Stock = request.Stock
        };

        await _productWriteRepository.AddAsync(product);
        await _productWriteRepository.SaveAsync();

        return product.Id;
    }
}


