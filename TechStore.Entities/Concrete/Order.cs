using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Entities.Concrete;

public class Order:BaseEntity
{
    [Display(Name = "Sipariş No")]
    [Required]
    [MaxLength(20)]
    public string OrderNumber { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPrice { get; set; }

    public DateTime OrderDate { get; set; }

    public OrderState OrderState { get; set; }

    [Required]
    public string UserId { get; set; }
    public AppUser User { get; set; }


    // Fatura Bilgileri (Hepsi Zorunlu)

    [Display(Name = "Ad")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Display(Name = "Soyad")]
    [Required(ErrorMessage = "{0} alanı zorunludur.")]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Display(Name = "Adres")]
    [Required(ErrorMessage = "Lütfen adres bilgisi giriniz.")]
    [MaxLength(200, ErrorMessage = "Adres alanı en fazla {1} karakter olabilir.")]
    public string Address { get; set; }
    [Display(Name = "Şehir")]
    [Required(ErrorMessage = "Şehir seçimi zorunludur.")]
    [MaxLength(50)]
    public string City { get; set; }
    [Display(Name = "Telefon")]
    [Required(ErrorMessage = "Telefon numarası zorunludur.")]
    [MaxLength(20)]
    public string Phone { get; set; }
    [Display(Name = "E-Posta")]
    [Required(ErrorMessage = "E-Posta adresi zorunludur.")]
    [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz.")]
    public string Email { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
}

public enum OrderState
{
    [Display(Name = "Ödeme Bekleniyor")]
    WaitingPayment = 0,
    [Display(Name = "Onaylandı")]
    Approved = 1,
    [Display(Name = "Kargoya Verildi")]
    Shipped = 2,
    [Display(Name = "Tamamlandı")]
    Completed = 3,
    [Display(Name = "İptal Edildi")]
    Cancelled = 4
}
