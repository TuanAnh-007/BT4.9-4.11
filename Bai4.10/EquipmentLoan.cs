using System;

namespace Bai4_10
{
    public class EquipmentLoan
    {
        public string LoanId { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }
    }
}