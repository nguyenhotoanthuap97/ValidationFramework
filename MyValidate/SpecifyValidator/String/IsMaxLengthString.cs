using MyValidate.Message;
using MyValidate.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.SpecifyValidator.String
{
    class IsMaxLengthString : ValidatorWrapper
    {
        public IsMaxLengthString(LangCode code) : base(code)
        {
        }

        public IsMaxLengthString(Validator.Validator innerValidator) : base(innerValidator)
        {
        }

        public override Validator.Validator Check(params object[] values)
        {
            base.Check(values);
            // do the check
            int max = 0;
            Int32.TryParse(values[1].ToString(), out max);
            if (values[0].ToString().IsMaxLength(max))
            {
                return NoError();

            }
            else
            {
                return AddError("Data", string.Format(messagesContainer.IsMaxLengthMessage, "Data"));
            }
        }
    }
}
