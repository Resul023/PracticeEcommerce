namespace ECommerceAPI.Application.Products.Commands.DeleteProduct;

public class DeleteCountryCommandHandler : IRequestHandler<DeleteProductCommandRequest>
{
    private readonly IProductWriteRepository _productWriteRepository;
    private readonly IProductReadRepository _productReadRepository;

    public DeleteCountryCommandHandler(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
    {
        this._productWriteRepository = productWriteRepository;
        this._productReadRepository = productReadRepository;
    }

    public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _productReadRepository.GetByIdAsync(request.Id,false);
        if (entity == null)
        {//TODO:
            
        }
        await _productWriteRepository.RemoveById(request.Id);
        await _productWriteRepository.SaveAsync();
        return Unit.Value;
    }
}
