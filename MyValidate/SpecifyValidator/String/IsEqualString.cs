using MyValidate.Message;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.String
{
    class IsEqualString : ValidatorWrapper
    {
        public IsEqualString(LangCode code) : base(code)
        {
        }

        public IsEqualString(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(params object[] values)
        {
            base.Check(values);
            // do the check
            if (!values[0].ToString().IsEqualTo(values[1].ToString()))
            {
                return AddError("Data", string.Format(messagesContainer.IsEqualToMessage, "Data"));
            }
            else
            {
                return NoError();
            }
        }
    }
}
