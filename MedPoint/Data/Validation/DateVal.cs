using System.ComponentModel.DataAnnotations;

namespace MedPoint.Data.Validation
{
    public class DateVal : ValidationAttribute
    {
        public DateVal(string errorMessage) : base("Date can be only higher")
        {
        }

        public override bool IsValid(object? value)
        {
            
            DateTime currentDate = Convert.ToDateTime(value);
            if (currentDate >= DateTime.Today)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}
