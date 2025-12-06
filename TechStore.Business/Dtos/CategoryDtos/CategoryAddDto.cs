using TechStore.Business.Abstract;

namespace TechStore.Business.Dtos.CategoryDtos;

public class CategoryAddDto:IDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? ParentCategoryId { get; set; }
}
