using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    public class Magazine : LibraryItemBase
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int year, int issueNumber)
            : base(title, year)
        {
            IssueNumber = issueNumber;
        }

        public override string GetItemType() => "Magazine";

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $", IssueNumber: {IssueNumber}";
        }
    }
}
