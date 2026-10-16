using System;

namespace Bai4_11
{
    public class RepairOrder
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string DeviceType { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ReceiveDate { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
    }
}