using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidate.Result
{
    public class UniqueError : IDisplayError
    {
        public override string Show(List<ValidationError> error)
        {
            string rs = "";
           error.GroupBy(o => o.Name)
                .Select(o => o.First())
                .ToList()
                .ForEach((item) =>
                   {
                       rs += item.ToString() + "\n";
                   });
            return rs;
        }
    }
}
