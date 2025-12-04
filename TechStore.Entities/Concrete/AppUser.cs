using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TechStore.Entities.Abstract;

namespace TechStore.Entities.Concrete;

public class AppUser:IdentityUser,IEntity
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
    public bool IsActive { get; set; } = true;  
    public bool IsDeleted { get; set; } = false;
}

public class AppRole : IdentityRole
{
}