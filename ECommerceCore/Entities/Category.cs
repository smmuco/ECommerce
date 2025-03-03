using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Descripton { get; set; }
        public string? Image { get; set; }
        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
        [Display(Name = "Top Category")]
        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        [Display(Name = "Order No")]
        public int OrderNo { get; set; }
        [Display(Name = "Create Date"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }
    }
}
