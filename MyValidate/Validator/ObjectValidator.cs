using System;
using MyValidate.ValidateMethod;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Validator
{
    public partial class Validator
    {
        #region " IsNotNull "

        public Validator IsNotNull(object value)
        {
            return IsNotNull("", value);
        }

        public Validator IsNotNull(string name, object value)
        {
            return IsNotNull(name, value, string.Format(messagesContainer.IsNotNullMessage, name));
        }

        public Validator IsNotNull(string name, object value, string message)
        {
            // do the check
            if (value.IsNotNull())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        #endregion

        #region " Is "

        public Validator Is(Func<bool> func)
        {
            return Is("", func);
        }

        public Validator Is(string name, Func<bool> func)
        {
            return Is(name, func, messagesContainer.IsMessage);
        }

        public Validator Is(string name, Func<bool> func, string message)
        {
            if (func())
            {
                return NoError();
            }
            else
            {
                return AddError(name, message);
            }
        }

        #endregion

        #region " IsNot "

        public Validator IsNot(Func<bool> func)
        {
            return IsNot("", func);
        }

        public Validator IsNot(string name, Func<bool> func)
        {
            return IsNot(name, func, messagesContainer.IsNotMessage);
        }

        public Validator IsNot(string name, Func<bool> func, string message)
        {
            if (func())
            {
                return AddError(name, message);
            }
            else
            {
                return NoError();
            }
        }

        #endregion

    }
}
