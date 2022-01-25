using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyaenidae.Models
{
    public class ArchiveViewModel
    {
        public int PageID { get; set; }
        public int TotalPages { get; set; }
        public int currentPage { get; set; }
    }
}
