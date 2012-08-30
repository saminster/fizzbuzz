using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return instance;
        }

        private string returnTopRangeLabel(int chkFbNumber)
        {
            throw new NotImplementedException();
        }

        private string returnMidRangeLabel(int chkFbNumber)
        {
            throw new NotImplementedException();
        }

        private string returnBasicRangeLabel(int chkFbNumber)
        {
            throw new NotImplementedException();
        }
    }

    public interface IRangeValidator
    {
        string DetermineNumberLabel(FBNumber fbNumber);

    }
}
