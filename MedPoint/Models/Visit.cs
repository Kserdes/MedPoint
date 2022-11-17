using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedPoint.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Imie i nazwisko pacjenta")]
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isBusy { get; set; }

        public List<DoctorVisit>? DoctorVisit { get; set; }
        public List<IdentityAccount>? AccountUsers { get; set;}
        [NotMapped]
        public List<SelectListItem>? Doctors { get; set; }
    }
}
