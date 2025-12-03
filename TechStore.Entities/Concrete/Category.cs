using System.ComponentModel.DataAnnotations;
namespace TechStore.Entities.Concrete;
public class Category:BaseEntity
{
    [Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir.")]
    public string Name { get; set; }

    [Display(Name = "Açıklama")]
    [MaxLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir.")]
    public string? Description { get; set; }
    [Display(Name = "Kategori Görseli")]
    public string? ImageUrl { get; set; }
    public int? ParentCategoryId { get; set; }
    public Category? ParentCategory { get; set; }
    public ICollection<Category> SubCategories { get; set; }
    public ICollection<Product> Products { get; set; }
    public Category()
    {
        SubCategories = new HashSet<Category>();
        Products = new HashSet<Product>();
    }
}
