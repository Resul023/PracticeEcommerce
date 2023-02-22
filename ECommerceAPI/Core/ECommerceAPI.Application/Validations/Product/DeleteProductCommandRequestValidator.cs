namespace ECommerceAPI.Application.Validations.Product;
public class DeleteProductCommandRequestValidator : AbstractValidator<DeleteProductCommandRequest>
{
	public DeleteProductCommandRequestValidator()
	{
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");
            
    }
}
