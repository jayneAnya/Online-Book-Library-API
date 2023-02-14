using PioneerOnlineLibrary.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Domain.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [MaxLength(5)]
        public RatingsEnum Rate { get; set; }


    }
}
