using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Attr
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    class ValidatorAttribute : Attribute
    {
        public string validatorType { get; }
        public object[] values { get; }

    }
}
