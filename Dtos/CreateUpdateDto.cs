using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public record CreateUpdateDto
    {
         [Required]
        public string Title{get;set;}=string.Empty;
        [Required]
        [Range(0,100)]
        public decimal Price{get;set;}
        
        
    }
}