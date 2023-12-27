using System.ComponentModel.DataAnnotations;
using lab9.Models;

namespace lab9.DTO;

public class ArticleDto
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(30, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Expiration date is required.")]
    [DataType(DataType.Date)]
    public DateTime ExpirationDate { get; set; }
    
    [Required(ErrorMessage = "Category is required.")]
    public Category Category { get; set; }
    
    [Required(ErrorMessage = "Description is required.")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Description { get; set; }
}