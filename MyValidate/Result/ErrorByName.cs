using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Result
{
    public class ErrorByName : IDisplayError
    {
        public string name;
        public ErrorByName(string _name)
        {
            name = _name;
        }

        public override string Show(List<ValidationError> Errors)
        {
            string rs = "";
            Errors.Where(o => o.Name == name).ToList().ForEach((item) =>
            {
                rs += item.ToString() + "\n";
            });
            return rs;
        }
    }
}
