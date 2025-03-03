using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Descripton { get; set; }
        public string? Logo { get; set; }
        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
        [Display(Name = "Order No")]
        public int OrderNo { get; set; }
        [Display(Name = "Create Date"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }
    }
}
