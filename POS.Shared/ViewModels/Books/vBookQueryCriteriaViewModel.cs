using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels.Books
{
    public class vBookQueryCriteriaViewModel
    {
        public int? BookId { get; set; }
        public string? Barcode { get; set; }
        public string? BookTitle { get; set; }
        public int? BookAuthorId { get; set; }
        public string? BookAuthorName { get; set; }
        public short? PublisherId { get; set; }
        public int? FromRemainBookCount { get; set; }
        public int? ToRemainBookCount { get; set; }
        public decimal? FromBookPrice { get; set; }
        public decimal? ToBookPrice { get; set; }
        public byte? SubjectId { get; set; }

    }
}
