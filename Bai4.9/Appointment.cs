using System;

namespace Bai4_9
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Doctor { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}