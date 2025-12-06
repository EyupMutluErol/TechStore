using FluentValidation;
using TechStore.Business.Dtos.CategoryDtos;

namespace TechStore.Business.ValidationRules.CategoryValidators;

public class CategoryUpdateDtoValidator:AbstractValidator<CategoryUpdateDto>
{
    public CategoryUpdateDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Kategori ID alanı zorunludur.")
            .GreaterThan(0).WithMessage("Geçersiz kategori ID.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Kategori adı boş geçilemez.")
            .MaximumLength(100).WithMessage("Kategori adı en fazla 100 karakter olabilir.");

        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.");
    }
}
