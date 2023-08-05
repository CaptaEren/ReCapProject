using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class SuccesDataResult<T> : DataResult<T>
    {
        public SuccesDataResult(T data, bool success, string message) : base(data, false, message)
        {
        }
        public SuccesDataResult(string message) : base(default, false, message)
        {
        }
        public SuccesDataResult(T data) : base(data, false)
        {
        }
        public SuccesDataResult() : base(default,false)
        {
        }
    }
}
