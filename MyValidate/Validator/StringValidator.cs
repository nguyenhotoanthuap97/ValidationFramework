using MyValidate.Message;
using MyValidate.ValidateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace MyValidate.Validator
//{
//    public class StringValidator : ValidatorWrapper
//    {

//        #region " IsNotNullOrEmpty "

//        public Validator IsNotNullOrEmpty(string value)
//        {
//            return IsNotNullOrEmpty("", value);
//        }

//        public Validator IsNotNullOrEmpty(string name, string value)
//        {
//            return IsNotNullOrEmpty(name, value, string.Format(messagesContainer.IsNotNullOrEmptyMessage, name));
//        }

//        public Validator IsNotNullOrEmpty(string name, string value, string message)
//        {
//            // do the check
//            if (value.IsNotNullOrEmpty())
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsNotNullOrWhiteSpace "

//        public Validator IsNotNullOrWhiteSpace(string value)
//        {
//            return IsNotNullOrWhiteSpace("", value);
//        }

//        public Validator IsNotNullOrWhiteSpace(string name, string value)
//        {
//            return IsNotNullOrWhiteSpace(name, value, string.Format(messagesContainer.IsNotNullOrWhiteSpaceMessage, name));
//        }

//        public Validator IsNotNullOrWhiteSpace(string name, string value, string message)
//        {
//            // do the check
//            if (value.IsNotNullOrWhiteSpace())
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsEmail "

//        public Validator IsEmail(string value)
//        {
//            return IsEmail("", value);
//        }

//        public Validator IsEmail(string name, string value)
//        {
//            return IsEmail(name, value, string.Format(messagesContainer.IsEmailMessage, name));
//        }

//        public Validator IsEmail(string name, string value, string message)
//        {
//            // do the check
//            if (value.IsEmail())
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsRegex "

//        public Validator IsRegex(string value, string exp)
//        {
//            return IsRegex("", value, exp);
//        }

//        public Validator IsRegex(string name, string value, string exp)
//        {
//            return IsRegex(name, value, exp, string.Format(messagesContainer.IsRegexMessage, name));
//        }

//        public Validator IsRegex(string name, string value, string exp, string message)
//        {
//            // do the check
//            if (value.IsRegex(exp))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsPassword "

//        public Validator IsPassword(string value)
//        {
//            return IsPassword("", value);
//        }

//        public Validator IsPassword(string name, string value)
//        {
//            return IsPassword(name, value, string.Format(messagesContainer.IsPasswordMessage, name));
//        }

//        public Validator IsPassword(string name, string value, string message)
//        {
//            // do the check
//            if (!value.IsPassword())
//            {
//                return AddError(name, message);
//            }
//            else
//            {
//                return NoError();
//            }
//        }

//        #endregion

//        #region " IsEqualTo "

//        public Validator IsMatch(string value, string compare)
//        {
//            return IsMatch("", value, compare);
//        }

//        public Validator IsMatch(string name, string value, string compare)
//        {
//            return IsMatch(name, value, compare, string.Format(messagesContainer.IsMatchMessage, name));
//        }

//        public Validator IsMatch(string name, string value, string compare, string message)
//        {
//            // do the check
//            if (!value.IsEqualTo(compare))
//            {
//                return AddError(name, message);
//            }
//            else
//            {
//                return NoError();
//            }
//        }

//        #endregion

//        #region " IsMinLength "

//        public Validator IsMinLength(string value, int min)
//        {
//            return IsMinLength("", value, min);
//        }

//        public Validator IsMinLength(string name, string value, int min)
//        {
//            return IsMinLength(name, value, min, string.Format(messagesContainer.IsMinLengthMessage, name, min));
//        }

//        public Validator IsMinLength(string name, string value, int min, string message)
//        {
//            // do the check
//            if (value.IsMinLength(min))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsMaxLength "

//        public Validator IsMaxLength(string value, int max)
//        {
//            return IsMaxLength("", value, max);
//        }

//        public Validator IsMaxLength(string name, string value, int max)
//        {
//            return IsMaxLength(name, value, max, string.Format(messagesContainer.IsMaxLengthMessage, name, max));
//        }

//        public Validator IsMaxLength(string name, string value, int max, string message)
//        {
//            // do the check
//            if (value.IsMaxLength(max))
//            {
//                return NoError();

//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsBetweenLength "

//        public Validator IsBetweenLength(string value, int min, int max)
//        {
//            return IsBetweenLength("", value, min, max);
//        }

//        public Validator IsBetweenLength(string name, string value, int min, int max)
//        {
//            return IsBetweenLength(name, value, min, max, string.Format(messagesContainer.IsBetweenLengthMessage, name, min, max));
//        }

//        public Validator IsBetweenLength(string name, string value, int min, int max, string message)
//        {
//            // do the check
//            if (value.IsBetweenLength(min, max))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsExactLength "

//        public Validator IsExactLength(string value, int exact)
//        {
//            return IsExactLength("", value, exact);
//        }

//        public Validator IsExactLength(string name, string value, int exact)
//        {
//            return IsExactLength(name, value, exact, string.Format(messagesContainer.IsExactLengthMessage, name, exact));
//        }

//        public Validator IsExactLength(string name, string value, int exact, string message)
//        {
//            // do the check
//            if (!value.IsExactLength(exact))
//            {
//                return AddError(name, message);
//            }
//            else
//            {
//                return NoError();
//            }
//        }

//        #endregion
//    }
//}
