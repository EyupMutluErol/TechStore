using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Entities.Concrete;

public class AppUser:IdentityUser
{
    [Display(Name = "Ad")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
    [MaxLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir.")]
    public string FirstName { get; set; }

    [Display(Name = "Soyad")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
    [MaxLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir.")]
    public string LastName { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}

public class AppRole : IdentityRole
{
}