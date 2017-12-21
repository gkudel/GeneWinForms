using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Proxy.Interceptors
{
    public enum InterceptorIdentity
    {
        GetData,
        SetData,
        LazyLoad
    }

    public enum InterceptorProiority
    {
        Low = 0,
        Default = 1,
        High = 2
    }
}
