using MyValidate.Message;
using MyValidate.Result;
using MyValidate.ValidateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Validator
{
    public class ValidatorWrapper : Validator
    {
        protected Validator innerValidator;

        public ValidatorWrapper(LangCode code) : base(code)
        {
            innerValidator = null;
        }

        public ValidatorWrapper(Validator innerValidator) : base()
        {
            this.innerValidator = innerValidator;
        }

        public new Validator AddError(string name, string message)
        {
            base.AddError(name, message);
            return this;
        }

        public override Validator Check(object value)
        {
            if (innerValidator != null)
                innerValidator.Check(value);
            return base.Check(value);
        }

        public override Validator Check(string name, object value)
        {
            if (innerValidator != null)
                innerValidator.Check(value);
            return base.Check(name, value);
        }

        public override Validator Check(string name, object value, string message)
        {
            if (innerValidator != null)
                innerValidator.Check(value);
            return base.Check(name, value, message);
        }

        public override Validator Check(params object[] values)
        {
            if (innerValidator != null)
                innerValidator.Check(values);
            return base.Check(values);
        }

        public override Validator Check(Func<bool> f, object value, string customErrorMessage)
        {
            if (innerValidator != null)
                innerValidator.Check(value);
            return base.Check(f, value, customErrorMessage);
        }

        public override string ErrorToString(IDisplayError error)
        {
            string errorStr = "";
            if (innerValidator != null)
            {
                errorStr = innerValidator.ErrorToString(error) + "\n";
            }
            
            return errorStr + error.Show(Errors);
        }
    }
}
