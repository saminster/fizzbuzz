using System;

namespace FizzBuzzApplication.Library
{
    public class RangeValidator : IRangeValidator
    {
        public string instance = null;

        public string DetermineNumberLabel(FBNumber fbNumber)
        {
            if(fbNumber.chkFBNumber > 1 && fbNumber.chkFBNumber < 101)
            {
                instance = returnBasicRangeLabel(fbNumber.chkFBNumber);
            }
            else if (fbNumber.chkFBNumber > 100 && fbNumber.chkFBNumber < 201)
            {
                instance = returnMidRangeLabel(fbNumber.chkFBNumber);
            }
            else if (fbNumber.chkFBNumber > 200 && fbNumber.chkFBNumber < 1001)
            {
                instance = returnTopRangeLabel(fbNumber.chkFBNumber);
            }
            else
            {
                var ex = new Exception("Value Out of Range");
                throw ex;
            }
            return instance;
        }

        private string returnTopRangeLabel(int chkFbNumber)
        {
            string numValue = string.Empty;

            var divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByHundred(),"century");

            numValue = divValidator.ValidateDivisors(new FBNumber {chkFBNumber = chkFbNumber});

            if(string.IsNullOrEmpty(numValue))
            {
                numValue = chkFbNumber.ToString();
            }

            return numValue;
        }

        private string returnMidRangeLabel(int chkFbNumber)
        {
            string numValue = string.Empty;

            var divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleBySevenandTen(), "septdeca");
            divValidator.DivisionRules.Add(new IsDivisibleBySeven(), "sept");
            divValidator.DivisionRules.Add(new IsDivisibleByTen(), "deca");

            numValue = divValidator.ValidateDivisors(new FBNumber {chkFBNumber = chkFbNumber});

            if (string.IsNullOrEmpty(numValue))
            {
                numValue = chkFbNumber.ToString();
            }

            return numValue;

        }


        private string returnBasicRangeLabel(int chkFbNumber)
        {
            string numValue = string.Empty;

            var divValidator = new DivisionValidators();
            divValidator.DivisionRules.Add(new IsDivisibleByThreeandFive(),"fizzbuzz");
            divValidator.DivisionRules.Add(new IsDivisibleByFive(),"buzz");
            divValidator.DivisionRules.Add(new IsDivisibleByThree(),"fizz");

            numValue = divValidator.ValidateDivisors(new FBNumber {chkFBNumber = chkFbNumber});

            if(string.IsNullOrEmpty(numValue))
            {
                numValue = chkFbNumber.ToString();
            }

            return numValue;
        }
    }

    public interface IRangeValidator
    {
        string DetermineNumberLabel(FBNumber fbNumber);

    }
}
