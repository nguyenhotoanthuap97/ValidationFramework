using MyValidate.Message;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.Object
{
    class IsNotObject : ValidatorWrapper
    {
        public IsNotObject(LangCode code) : base(code)
        {
        }

        public IsNotObject(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(Func<bool> f, object value, string customErrorMessage)
        {
            base.Check(value);
            if (f())
            {
                return AddError("Data", customErrorMessage);
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
