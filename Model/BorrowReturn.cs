using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BorrowReturn
    {
        public int BorrowId { get; set; }
        public string BookId { get; set; }
        public string  UserId { get; set; }
        public DateTime BorrowTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public DateTime FactReturnTime { get; set; }
        public double Fine { get; set; }
        public int RenewCount { get; set; }
        public string BorrowRemark { get; set; }

        public DateTime  TimeIn { get; set; } //开始日期
        public DateTime  TimeOut { get; set; } //结束日期
    }
}
