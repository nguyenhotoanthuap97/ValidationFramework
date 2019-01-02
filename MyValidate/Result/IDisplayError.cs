using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Result
{
    public abstract class IDisplayError
    {
        public abstract string Show(List<ValidationError> error);
    }
}
