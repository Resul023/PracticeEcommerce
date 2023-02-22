namespace ECommerceAPI.Application.Products.Queries.GetAllProduct;
public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
{
    private readonly IMapper _mapper;
    private readonly IProductReadRepository _productReadRepository;
    public GetAllProductQueryHandler(IMapper mapper, IProductReadRepository productReadRepository)
    {
        this._mapper = mapper;
        this._productReadRepository = productReadRepository;
    }

    public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var totalProductCount = _productReadRepository.GetAll(false).Count();
        var products = await _productReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .ProjectTo<ProductGetDto>(_mapper.ConfigurationProvider).ToListAsync();

        return new()
        {
            Products = products,
            TotalProductCount = totalProductCount
        };
    }
}

