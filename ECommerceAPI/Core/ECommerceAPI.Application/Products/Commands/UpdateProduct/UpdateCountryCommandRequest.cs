namespace ECommerceAPI.Application.Products.Commands.UpdateProduct;
public class UpdateCountryCommandRequest : IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}
public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandRequest>
{
    private readonly IProductWriteRepository _productWriteRepository;
    private readonly IProductReadRepository _productReadRepository;
    public UpdateCountryCommandHandler(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
    {
        this._productWriteRepository = productWriteRepository;
        this._productReadRepository = productReadRepository;
    }
    public async Task<Unit> Handle(UpdateCountryCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _productReadRepository.GetByIdAsync(request.Id.ToString(), false);

        if (entity == null)
        {//TODO:

        }
        entity.Price = request.Price;
        entity.Name = request.Name;
        entity.Stock = request.Stock;
        _productWriteRepository.Update(entity);
        await _productWriteRepository.SaveAsync();
        return Unit.Value;
    }
}