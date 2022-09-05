using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public bool Admitted { get; set; }
        public string Allergies { get; set; } = null!;
        public string HealthHistory { get; set; } = null!;
        public int StaffId { get; set; }
        public string Staffs { get; set; } = null!;
    }
}
