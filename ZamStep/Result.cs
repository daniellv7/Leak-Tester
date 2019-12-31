using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSR
{
    public class Result
    {
        public Result()
        {

        }

        public bool Failed { get; internal set; }
        public string Message { get; internal set; }
        public int Code { get; internal set; }
    }
}
