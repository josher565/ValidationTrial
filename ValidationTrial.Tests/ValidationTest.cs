using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationTrial.Models;
using ValidationTrial.Models.Valdation;
using ValidationTrial.Tests.Builders;

namespace ValidationTrial.Tests
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void NotSettingNameFails()
        {
            //arrange
            var remainsNameless = TyraTheModelBuilder.Build();
            remainsNameless.ModelName = String.Empty;
            var validator = new MyValidator();

            //act
            bool valid = validator.IsValid(remainsNameless);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void SettingNameSucceeds(){
            
            //arrange
            var fame = TyraTheModelBuilder.Build();
            fame.ModelName = "Candice Swanepoel";
            var validator = new MyValidator();

            //act
            bool valid = validator.IsValid(fame);

            //assert
            Assert.IsTrue(valid);
        }
    }
}
