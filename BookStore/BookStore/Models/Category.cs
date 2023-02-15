using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1,100,ErrorMessage = "Range should be in between 1 to 100")]
        public int DisaplayOrder { get; set; }

        public DateTime dateTime { get; set; }

    }
}
