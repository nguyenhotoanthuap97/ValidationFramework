using MyValidate.Message;
using MyValidate.ValidateMethod;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace MyValidate.Validator
//{
//    public class DateTimeValidator : ValidatorWrapper
//    {
        
//        #region " IsDate "

//        public Validator IsDate(object value)
//        {
//            return IsDate("", value);
//        }

//        public Validator IsDate(string name, object value)
//        {
//            return IsDate(name, value, string.Format(messagesContainer.IsDateMessage, name));
//        }

//        public Validator IsDate(string name, object value, string message)
//        {
//            // do the check
//            if (value.IsDate())
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        public Validator IsDate(object value, CultureInfo info)
//        {
//            return IsDate("", value, info);
//        }

//        public Validator IsDate(string name, object value, CultureInfo info)
//        {
//            return IsDate(name, value, string.Format(messagesContainer.IsDateMessage, name), info);
//        }

//        public Validator IsDate(string name, object value, string message, CultureInfo info)
//        {
//            // do the check
//            if (value.IsDate(info))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        public Validator IsDate(object value, CultureInfo info, DateTimeStyles styles)
//        {
//            return IsDate(string.Empty, value, info, styles);
//        }

//        public Validator IsDate(string name, object value, CultureInfo info, DateTimeStyles styles)
//        {
//            return IsDate(name, value, string.Format(messagesContainer.IsDateMessage, name), info, styles);
//        }

//        public Validator IsDate(string name, object value, string message, CultureInfo info, DateTimeStyles styles)
//        {
//            // do the check
//            if (value.IsDate(info, styles))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsGreaterThan "

//        public Validator IsGreaterThan(DateTime value, DateTime compare)
//        {
//            return IsGreaterThan("", value, compare);
//        }

//        public Validator IsGreaterThan(string name, DateTime value, DateTime compare)
//        {
//            return IsGreaterThan(name, value, compare, string.Format(messagesContainer.IsGreaterThanMessage, name, compare));
//        }

//        public Validator IsGreaterThan(string name, DateTime value, DateTime compare, string message)
//        {
//            // do the check
//            if (value.IsGreaterThan(compare))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsGreaterThanOrEqualTo "

//        public Validator IsGreaterThanOrEqualTo(DateTime value, DateTime compare)
//        {
//            return IsGreaterThanOrEqualTo("", value, compare);
//        }

//        public Validator IsGreaterThanOrEqualTo(string name, DateTime value, DateTime compare)
//        {
//            return IsGreaterThanOrEqualTo(name, value, compare, string.Format(messagesContainer.IsGreaterThanOrEqualToMessage, name, compare));
//        }

//        public Validator IsGreaterThanOrEqualTo(string name, DateTime value, DateTime compare, string message)
//        {
//            // do the check
//            if (value.IsGreaterThanOrEqualTo(compare))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsLessThan "

//        public Validator IsLessThan(DateTime value, DateTime compare)
//        {
//            return IsLessThan("", value, compare);
//        }

//        public Validator IsLessThan(string name, DateTime value, DateTime compare)
//        {
//            return IsLessThan(name, value, compare, string.Format(messagesContainer.IsLessThanMessage, name, compare));
//        }

//        public Validator IsLessThan(string name, DateTime value, DateTime compare, string message)
//        {
//            // do the check
//            if (value.IsLessThan(compare))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsLessThanOrEqualTo "

//        public Validator IsLessThanOrEqualTo(DateTime value, DateTime compare)
//        {
//            return IsLessThanOrEqualTo("", value, compare);
//        }

//        public Validator IsLessThanOrEqualTo(string name, DateTime value, DateTime compare)
//        {
//            return IsLessThanOrEqualTo(name, value, compare, string.Format(messagesContainer.IsLessThanOrEqualToMessage, name, compare));
//        }

//        public Validator IsLessThanOrEqualTo(string name, DateTime value, DateTime compare, string message)
//        {
//            // do the check
//            if (value.IsLessThanOrEqualTo(compare))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsEqualTo "

//        public Validator IsEqualTo(DateTime value, DateTime compare)
//        {
//            return IsEqualTo("", value, compare);
//        }

//        public Validator IsEqualTo(string name, DateTime value, DateTime compare)
//        {
//            return IsEqualTo(name, value, compare, string.Format(messagesContainer.IsEqualToMessage, name, compare));
//        }

//        public Validator IsEqualTo(string name, DateTime value, DateTime compare, string message)
//        {
//            // do the check
//            if (value.IsEqualTo(compare))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsBetweenInclusive "

//        public Validator IsBetweenInclusive(DateTime value, DateTime from, DateTime to)
//        {
//            return IsBetweenInclusive("", value, from, to);
//        }

//        public Validator IsBetweenInclusive(string name, DateTime value, DateTime from, DateTime to)
//        {
//            return IsBetweenInclusive(name, value, from, to, string.Format(messagesContainer.IsBetweenInclusiveMessage, name, from, to));
//        }

//        public Validator IsBetweenInclusive(string name, DateTime value, DateTime from, DateTime to, string message)
//        {
//            // do the check
//            if (value.IsBetweenInclusive(from, to))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion

//        #region " IsBetweenExclusive "

//        public Validator IsBetweenExclusive(DateTime value, DateTime from, DateTime to)
//        {
//            return IsBetweenExclusive("", value, from, to);
//        }

//        public Validator IsBetweenExclusive(string name, DateTime value, DateTime from, DateTime to)
//        {
//            return IsBetweenExclusive(name, value, from, to, string.Format(messagesContainer.IsBetweenExclusiveMessage, name, from, to));
//        }

//        public Validator IsBetweenExclusive(string name, DateTime value, DateTime from, DateTime to, string message)
//        {
//            // do the check
//            if (value.IsBetweenExclusive(from, to))
//            {
//                return NoError();
//            }
//            else
//            {
//                return AddError(name, message);
//            }
//        }

//        #endregion
//    }
//}
