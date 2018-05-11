using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationTrial.Models.Valdation 
{
    public class MyValidator{

        public ICollection<ValidationResult> Results { get; set; }

        public bool IsValid(object validationTarget){
            var ctx  = new ValidationContext(validationTarget, null, null);
            bool r = Validator.TryValidateObject(validationTarget, ctx, Results);
            return r;
        }
    }
}