using MyValidate.Message;
using MyValidate.ValidateMethod;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.String
{
    class IsPassword : ValidatorWrapper
    {
        public IsPassword(LangCode code) : base(code)
        {
        }

        public IsPassword(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(object value)
        {
            base.Check(value);
            return Check("Data", value);
        }

        public override Validator.Validator Check(string name, object value)
        {
            base.Check(value);
            return Check(name, value, string.Format(messagesContainer.IsPasswordMessage, name));
        }

        public override Validator.Validator Check(string name, object value, string message)
        {
            base.Check(value);
            //do the check
            if (!value.ToString().IsPassword())
            {
                return AddError(name, message);
            }
            else
            {
                return NoError();
            }
        }

        public override Validator.Validator Check(params object[] values)
        {
            return Check(values[0]);
        }
    }
}
