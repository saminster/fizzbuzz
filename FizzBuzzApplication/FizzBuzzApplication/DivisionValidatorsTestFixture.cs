using FizzBuzzApplication.Library;
using NUnit.Framework;

namespace FizzBuzzApplication
{
    [TestFixture]
    public class DivisionValidatorsTests
    {
        [Test]
        public void CheckNumberNotDivisibleByThree()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByThree(), "fizz");

            string result = divValidator.ValidateDivisors(new FBNumber {chkFBNumber = 2});

            Assert.AreNotEqual(result, "fizz");
        }

        [Test]
        public void CheckNumberIsDivisibleByThree()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByThree(),"fizz");

            string result = divValidator.ValidateDivisors(new FBNumber {chkFBNumber = 24});

            Assert.AreEqual(result,"fizz");
        }

        [Test]
        public void CheckNumberIsDivisibleByFive()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByFive(), "buzz");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 20 });

            Assert.AreEqual(result, "buzz");
        }

        [Test]
        public void CheckNumberNotDivisibleByFive()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByFive(), "buzz");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 36 });

            Assert.AreNotEqual(result, "buzz");
        }

        [Test]
        public void CheckNumberIsDivisibleBySeven()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleBySeven(), "sept");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 21 });

            Assert.AreEqual(result, "sept");
        }

        [Test]
        public void CheckNumberNotDivisibleBySeven()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleBySeven(), "sept");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 55 });

            Assert.AreNotEqual(result, "sept");
        }
        [Test]
        public void CheckNumberNotDivisibleByTen()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByTen(), "deca");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 77 });

            Assert.AreNotEqual(result, "deca");
        }

        [Test]
        public void CheckNumberIsDivisibleByTen()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByTen(), "deca");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 80 });

            Assert.AreEqual(result, "deca");
        }

        [Test]
        public void CheckNumberIsDivisibleByThreeAndFive()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByThreeandFive(), "fizzbuzz");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 15 });

            Assert.AreEqual(result, "fizzbuzz");
        }


        [Test]
        public void CheckNumberNotDivisibleByThreeAndFive()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByThreeandFive(), "fizzbuzz");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 99 });

            Assert.AreNotEqual(result, "fizzbuzz");
        }

        [Test]
        public void CheckNumberIsDivisibleBySevenAndTen()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleBySevenandTen(), "septdeca");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 70 });

            Assert.AreEqual(result, "septdeca");
        }
        [Test]
        public void CheckNumberNotDivisibleBySevenAndTen()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleBySevenandTen(), "septdeca");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 49 });

            Assert.AreNotEqual(result, "septdeca");
        }

        [Test]
        public void CheckNumberNotDivisibleByHundred()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByHundred(), "century");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 250 });

            Assert.AreNotEqual(result, "century");
        }

        [Test]
        public void CheckNumberIsDivisibleByHundred()
        {
            IDivisionValidators divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByHundred(), "century");

            string result = divValidator.ValidateDivisors(new FBNumber { chkFBNumber = 400 });

            Assert.AreEqual(result, "century");
        }






    }


}
