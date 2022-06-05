using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a prdouct name.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a price for product.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        /*[Required(ErrorMessage = "Please add an product image.")]
        public string?[] Image { get; set; }*/
        [Required(ErrorMessage = "Please enter a colour.")]
        public int ColourId { get; set; }
        public Colour? Colour { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public String Supplier { get; set; }
        public String ImagePath { get; set; }  
        public string Slug =>
            ProductName?.Replace(' ', '-').ToLower() + '-' + CategoryId.ToString();
    }
}
