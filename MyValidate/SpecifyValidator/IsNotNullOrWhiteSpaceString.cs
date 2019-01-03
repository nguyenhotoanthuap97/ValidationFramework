using MyValidate.Message;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator
{
    public class IsNotNullOrWhiteSpaceString : ValidatorWrapper
    {
        public IsNotNullOrWhiteSpaceString(LangCode code) : base(code)
        {
        }

        public IsNotNullOrWhiteSpaceString(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(object value)
        {
            return Check("", value.ToString());
        }

        public override Validator.Validator Check(string name, object value)
        {
            return Check(name, value.ToString(), string.Format(messagesContainer.IsNotNullOrWhiteSpaceMessage, name));
        }

        public override Validator.Validator Check(string name, object value, string message)
        {
            // do the check
            if (value.ToString().IsNotNullOrWhiteSpace())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }
    }
}
