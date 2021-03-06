﻿using System;
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
    public partial class Validator
    {
        #region " Constructor "

        public Validator()
        {
            Errors = new List<ValidationError>();
            messagesContainer = MessagesFactory.getInstance().Create();
        }

        public Validator(LangCode code)
        {
            Errors = new List<ValidationError>();
            messagesContainer = MessagesFactory.getInstance().Create(code);
        }

        #endregion

        #region " Properties "

        public MessagesContainer messagesContainer ;

        public bool IsValid()
        {
            return Errors.Count == 0;
        }

        #endregion

        public List<ValidationError> Errors { get; set; }

        public string ErrorToString(IDisplayError error)
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

        public Validator Must(Func<bool> func)
        {
            return Must("", func);
        }

        public Validator Must(string name, Func<bool> func)
        {
            return Must(name, func, string.Format(messagesContainer.IsNotMessage,name));
        }

        public Validator Must(string name, Func<bool> func, string message)
        {
            if (!func())
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
