using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Domain.Model
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
