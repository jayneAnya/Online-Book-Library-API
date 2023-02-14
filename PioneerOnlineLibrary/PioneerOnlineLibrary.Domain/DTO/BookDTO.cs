using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Domain.DTO
{
    public class BookDTO
    {
        [MaxLength(10)]
        public long ISBN { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Author { get; set; } = string.Empty;
        public int Pages { get; set; }

        public bool IsAvailable { get; set; }
        public User User { get; set; } = null!;

    }
}
