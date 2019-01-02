using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Result
{
    public class ValidationError
    {
        public ValidationError()
        {
            Name = "";
            Message = "";
        }

        public string Name { get; set; }
        public string Message { get; set; }


        public static ValidationError Create(string name, string message)
        {
            ValidationError error = new ValidationError()
            {
                Name = name,
                Message = message
            };

            return error;
        }

        public override string ToString()
        {
            return Message; 
        }
    }
}
