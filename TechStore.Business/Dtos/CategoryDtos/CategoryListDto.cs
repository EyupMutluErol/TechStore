using TechStore.Business.Abstract;

namespace TechStore.Business.Dtos.CategoryDtos;

public class CategoryListDto:IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public int? ParentCategoryId { get; set; }
    public string ParentCategoryName { get; set; }
}
