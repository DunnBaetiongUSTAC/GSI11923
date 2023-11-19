using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCollection.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string BookCode { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }

    }
}
