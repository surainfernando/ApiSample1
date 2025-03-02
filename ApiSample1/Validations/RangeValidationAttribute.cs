using System.ComponentModel.DataAnnotations;

namespace ApiSample1.Validations
{
    public class RangeValidationAttribute : ValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        // Constructor to initialize the range
        public RangeValidationAttribute(int min, int max,int max2)
        {
            _min = min;
            _max = max;
            this.ErrorMessage = $"Value must be between sds {_min} and {_max}.";
        }

        // Override IsValid to perform the validation
        public override bool IsValid(object value)
        {
            if (value == null) return true; // If the value is null, assume valid (can also be handled based on business logic)

            // Check if the value is an integer and within the specified range
            if (value is int intValue)
            {
                return intValue >= _min && intValue <= _max;
            }

            return false; // If value is not of expected type, return invalid
        }
    }

}
