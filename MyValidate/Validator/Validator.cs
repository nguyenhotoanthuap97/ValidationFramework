using System;
using System.Collections.Generic;
using System.Linq;
using MyValidate.Message;
using System.Text;
using System.Threading.Tasks;
using MyValidate.Result;
using MyValidate.ValidateMethod;

namespace MyValidate.Validator
{
    public partial class Validator
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

        /// <summary>
        /// The full list of errors currently available
        /// </summary>
        public List<ValidationError> Errors { get; set; }

        /// <summary>
        /// Returns a list of errors with the specified name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<ValidationError> ErrorByName(string name)
        {
            return Errors.Where(o => o.Name == name).ToList();
        }

        /// <summary>
        /// This will return a unique set of Errors by Name and return the first instance of each error.
        /// </summary>
        public List<ValidationError> UniqueErrors
        {
            get
            {
                return Errors
                    .GroupBy(o => o.Name)
                    .Select(o => o.First())
                    .ToList();
            }
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
    }
}
