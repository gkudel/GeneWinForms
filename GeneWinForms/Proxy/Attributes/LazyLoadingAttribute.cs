using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Proxy.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LazyLoadingAttribute : Attribute
    {
        public Type RepositoryType { get; set; }
    }
}
