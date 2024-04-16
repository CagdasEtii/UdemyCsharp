using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Kodu")]
        public int ProductId { get; set; }
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; } = string.Empty;
        [Display(Name = "Ürün Fiyatı")]
        public decimal ProductPrice { get; set; }
        [Display(Name = "Ürün Resmi")]
        public string ProductImage { get; set; } = string.Empty;
        [Display(Name = "Ürün Açıklaması")]
        public string ProductDescription { get; set; } = string.Empty;
        [Display(Name = "Ürün stokta mı?")]
        public bool IsActive { get; set; }
        [Display(Name = "Ürün Kategori Kodu")]
        public int ProductCategoryId { get; set; }
    }
}