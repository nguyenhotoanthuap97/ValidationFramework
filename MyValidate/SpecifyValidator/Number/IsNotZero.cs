using MyValidate.Message;
using MyValidate.ValidateMethod;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.Number
{
    class IsNotZero : ValidatorWrapper
    {
        public IsNotZero(LangCode code) : base(code)
        {
        }

        public IsNotZero(Validator.Validator innerValidator) : base(innerValidator)
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
            return Check(name, value, string.Format(messagesContainer.IsNotZeroMessage, name));
        }

        public override Validator.Validator Check(string name, object value, string message)
        {
            base.Check(value);
            // do the check
            if (Int32.Parse(value.ToString()).IsNotZero())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        public override Validator.Validator Check(params object[] values)
        {
            return Check(values[0]);
        }
    }
}
