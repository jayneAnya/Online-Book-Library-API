using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Domain.Model
{
    public class Book
    {

        [Key]
        public Guid BookId { get; set; } = Guid.NewGuid();
        public string ISBN { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string PublicationDate { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;

        public int Pages { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public string Author { get; set; } = string.Empty;

        public User User { get; set; } = null!;
        public bool IsAvailable { get; set; }
    }
}
