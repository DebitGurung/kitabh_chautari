using System.ComponentModel.DataAnnotations;

namespace KitabhChautari.Maui.Models
{
    public enum Category
    {
        [Display(Name = "Best Seller")]
        BestSeller,

        [Display(Name = "Latest Books")]
        Latest,

        [Display(Name = "On Sale")]
        OnSale
    }
}