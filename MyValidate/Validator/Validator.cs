using System;
using System.Collections.Generic;
using System.Linq;
using MyValidate.Message;
using System.Text;
using System.Threading.Tasks;
using MyValidate.Result;
using MyValidate.ValidateMethod;
using System.Diagnostics;

namespace MyValidate.Validator
{
    public class Validator
    {
        #region " Constructor "

        public Validator()
        {
            Errors = new List<ValidationError>();
            messagesContainer = MessagesFactory.Create();
        }

        public Validator(LangCode code)
        {
            Errors = new List<ValidationError>();
            messagesContainer = MessagesFactory.Create(code);
        }

        #endregion

        #region " Properties "

        public MessagesContainer messagesContainer ;

        public bool IsValid()
        {
            return Errors.Count == 0;
        }

        #endregion

        #region " Validation Errors "

        public List<ValidationError> Errors { get; set; }

        public virtual string ErrorToString(IDisplayError error)
        {
            return error.Show(Errors);
        }

        public Validator AddError(string message)
        {
            return AddError("", message);
        }

        public Validator AddError(string name, string message)
        {
            ValidationError error = ValidationError.Create(name.EmptyStringIfNull(), message);
            Errors.Add(error);
            return this;
        }

        protected Validator NoError()
        {
            return this;
        }

        #endregion

        public virtual Validator Check(object value)
        {
            return this;
        }

        public virtual Validator Check(string name, object value)
        {
            return this;
        }

        public virtual Validator Check(string name, object value, string message)
        {
            return this;
        }

        public Validator Must(Func<bool> func)
        {
            return Must("", func);
        }

        public Validator Must(string name, Func<bool> func)
        {
            return Must(name, func, messagesContainer.IsNotMessage);
        }

        public Validator Must(string name, Func<bool> func, string message)
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

    }
}
