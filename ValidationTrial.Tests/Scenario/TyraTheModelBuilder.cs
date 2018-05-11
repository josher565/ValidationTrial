using ValidationTrial.Models;
using System.Collections.Generic;

namespace ValidationTrial.Tests.Builders{
    public class TyraTheModelBuilder {
        public static SuperModel Build(){
            return new SuperModel() { 
                ModelName = "Dipti Sharma", 
                Hometown="Rudrapur, Uttarakhand, India",
                Designers = new List<string> { "Balenciaga", "Alexander Wang" }
            };
        }
    }
}