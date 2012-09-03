using System.Collections.Generic;

namespace FizzBuzzApplication.Library
{
    public class DivisionValidators : IDivisionValidators
    {
        #region Properties

        public IDictionary<IDivisionRule, string> DivisionRules { get; set; }
        public string numberLabel = null;
        
        #endregion

        public DivisionValidators()
        {
            DivisionRules = new Dictionary<IDivisionRule, string>
                                {
                                   
                                };
        }

        #region Methods

        public string ValidateDivisors(FBNumber fbNumber)
        {
            if(fbNumber.chkFBNumber > 0)
            {
                foreach (var numberDivisorValidation in DivisionRules)
                {
                    if(numberDivisorValidation.Key.Validate(fbNumber))
                    {
                        numberLabel = numberDivisorValidation.Value;
                    }

                }

            }

            return numberLabel;

        }

        #endregion



    }

    public interface IDivisionValidators
    {
        string ValidateDivisors(FBNumber fbNumber);
        IDictionary<IDivisionRule, string> DivisionRules { get; set; }
    }

    #region Division Rules

    public class IsDivisibleByThree : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if(fbNumber.chkFBNumber%3==0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleByFive : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleByThreeandFive : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 3 == 0 && fbNumber.chkFBNumber % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleBySeven : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 7 == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleByTen : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 10 == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleBySevenandTen : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 7 == 0 && fbNumber.chkFBNumber % 10 == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class IsDivisibleByHundred : IDivisionRule
    {
        public bool Validate(FBNumber fbNumber)
        {
            if (fbNumber.chkFBNumber % 100 == 0)
            {
                return true;
            }
            return false;
        }
    }
    
    public interface IDivisionRule
    {
        bool Validate(FBNumber fbNumber);
    }


    #endregion

 





}
