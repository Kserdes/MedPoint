using System.ComponentModel.DataAnnotations;

namespace MedPoint.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime DateTime { get; set; }

        public List<DoctorVisit> DoctorVisit { get; set; }
        public List<IdentityAccount> AccountUsers { get; set;}
    }
}
