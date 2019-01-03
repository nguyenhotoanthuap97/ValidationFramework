using MyValidate.Message;
using MyValidate.ValidateMethod;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.Datetime
{
    class IsSmallerThanDate : ValidatorWrapper
    {
        public IsSmallerThanDate(LangCode code) : base(code)
        {
        }

        public IsSmallerThanDate(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(params object[] values)
        {
            base.Check(values);
            // do the check
            if (((DateTime)values[0]).IsLessThan((DateTime)values[1]))
            {
                return NoError();
            }
            else
            {
                return AddError("Data", string.Format(messagesContainer.IsLessThanMessage, "Data", values[1]));
            }
        }
    }
}
