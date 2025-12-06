using FluentValidation;
using TechStore.Business.Dtos.ProductDtos;

namespace TechStore.Business.ValidationRules.ProductValidators;

public class ProductAddDtoValidator:AbstractValidator<ProductAddDto>
{
    public ProductAddDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ürün adı zorunludur.")
            .MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır.");

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Ürün kodu (SKU) zorunludur.");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır.")
            .NotEmpty().WithMessage("Fiyat alanı zorunludur.");

        RuleFor(x => x.StockQuantity)
            .GreaterThanOrEqualTo(0).WithMessage("Stok adedi negatif olamaz.")
            .NotEmpty().WithMessage("Stok adedi zorunludur.");

        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("Lütfen bir kategori seçiniz.")
            .GreaterThan(0).WithMessage("Geçerli bir kategori seçiniz.");
    }
}
