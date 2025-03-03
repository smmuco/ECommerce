using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Product Code")]
        public string? ProductCode { get; set; }
        public int Stock { get; set; }
        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
        [Display(Name = "Home")]
        public bool IsHome { get; set; }
        [Display(Name = "Top Menu")]
        public bool IsTopMenu { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Display(Name = "Brand Id")]
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        [Display(Name = "Order No")]
        public int OrderNo { get; set; }
        [Display(Name = "Create Date"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
