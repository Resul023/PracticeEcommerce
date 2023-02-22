namespace ECommerceAPI.Application.Products.Queries.GetByIdProduct;

public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
{
    private readonly IMapper _mapper;
    private readonly IProductReadRepository _productReadRepository;
    public GetByIdProductQueryHandler(IMapper mapper, IProductReadRepository productReadRepository)
    {
        this._mapper = mapper;
        this._productReadRepository = productReadRepository;
    }
    public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
    {
        var product = await _productReadRepository.GetWhere(x=>x.Id == request.Id,false)
            .ProjectTo<GetByIdProductQueryResponse>(_mapper.ConfigurationProvider).SingleAsync();

        return product;
    }
}
