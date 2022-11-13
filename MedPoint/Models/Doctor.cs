using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MedPoint.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Imię i nazwisko")]
        [Required(ErrorMessage = "Wpisz poprawne dane")]
        public string FullName { get; set; }
        [DisplayName("Specjalizacja")]
        [Required(ErrorMessage ="Wpisz poprawne dane")]
        public string Specialization { get; set; }
        [DisplayName("Zdjęcie")]
        [Required(ErrorMessage = "Wpisz poprawne dane")]
        public string ProfilePictureURL { get; set; }

        public List<DoctorVisit>? DoctorVisit { get; set; }

    }
}
