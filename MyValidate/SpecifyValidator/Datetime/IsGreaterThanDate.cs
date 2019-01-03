using MyValidate.Message;
using MyValidate.Validator;
using MyValidate.ValidateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.Datetime
{
    class IsGreaterThanDate : ValidatorWrapper
    {
        public IsGreaterThanDate(LangCode code) : base(code)
        {
        }

        public IsGreaterThanDate(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(params object[] values)
        {
            base.Check(values);
            // do the check
            if (((DateTime)values[0]).IsGreaterThan((DateTime)values[1]))
            {
                return NoError();
            }
            else
            {
                return AddError("Data", string.Format(messagesContainer.IsGreaterThanMessage, "Data", values[1]));
            }
        }
    }
}
