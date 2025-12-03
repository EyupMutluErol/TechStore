using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Entities.Concrete;

public class Product:BaseEntity
{
    [Display(Name = "Ürün Adı")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir.")]
    public string Name { get; set; }
    [Display(Name = "Ürün Kodu")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir.")]
    public string Code { get; set; }
    [Display(Name = "Fiyat")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    [Display(Name = "Stok Adedi")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [Range(0, int.MaxValue, ErrorMessage = "Stok adedi 0'dan küçük olamaz.")]
    public int StockQuantity { get; set; }
    [Display(Name = "Açıklama")]
    public string? Description { get; set; }
    [Display(Name = "Ürün Görseli")]
    public string? ImageUrl { get; set; }
    public bool IsHome { get; set; }
    public bool IsFeatured { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}
