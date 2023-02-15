
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
