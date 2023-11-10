using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The category name can not be blank!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3-50 characters!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
       

    }
}