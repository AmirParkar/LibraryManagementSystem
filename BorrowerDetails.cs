using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public partial class BorrowerDetails
    {
        public int IssueId { get; set; }
        public string BookName { get; set; }
        public DateTime? BorrowedFromDate { get; set; }
        public DateTime? BorrowedToDate { get; set; }
        public string IssuedBy { get; set; }

        public override string ToString()
        {
            return string.Join(",", IssueId, BookName, BorrowedFromDate, BorrowedToDate, IssuedBy);
        }
    }
}
