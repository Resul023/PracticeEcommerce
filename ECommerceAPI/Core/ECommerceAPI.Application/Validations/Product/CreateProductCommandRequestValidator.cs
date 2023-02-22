namespace ECommerceAPI.Application.Validations.Product;
public class CreateProductCommandRequestValidator : AbstractValidator<CreateProductCommandRequest>
{
	public CreateProductCommandRequestValidator()
	{
        RuleFor(c => c.Name)
            .MaximumLength(200)
            .WithMessage("Maximum length must be 200")
            .NotEmpty()
            .WithMessage("CountryName required");
    }
}
