using System.ComponentModel.DataAnnotations;

namespace MedPoint.Models
{
    public class DoctorVisit
    {
        [Key]
        public int ID { get; set; }
        public int DoctorID {get; set;}
        public int VisitID { get; set; }

        public Doctor Doctor { get; set; }
        public Visit Visit { get; set; }
    }
}
