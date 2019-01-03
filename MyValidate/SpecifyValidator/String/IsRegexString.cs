using MyValidate.Message;
using MyValidate.Validator;
using MyValidate.ValidateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.String
{
    class IsRegexString : ValidatorWrapper
    {
        public IsRegexString(LangCode code) : base(code)
        {
        }

        public IsRegexString(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(params object[] values)
        {
            base.Check(values);
            if (values[0].ToString().IsRegex(values[1].ToString()))
            {
                return NoError();
            }
            else
            {
                return AddError("Data", string.Format(messagesContainer.IsEmailMessage, "Data"));
            }
        }
    }
}
