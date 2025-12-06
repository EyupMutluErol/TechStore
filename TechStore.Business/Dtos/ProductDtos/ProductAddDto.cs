using TechStore.Business.Abstract;

namespace TechStore.Business.Dtos.ProductDtos;

public class ProductAddDto:IDto
{
    public string Name { get; set; }
    public string Code { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsHome { get; set; }
    public bool IsFeatured { get; set; }
    public int CategoryId { get; set; }
}
