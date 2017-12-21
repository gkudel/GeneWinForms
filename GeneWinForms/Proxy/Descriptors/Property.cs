using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Tools;
using System.Reflection;

namespace GeneWinForms.Proxy.Descriptors
{
    internal class Property
    {
        public Property(string name, PropertyInfo pInfo)
        {
            Validator.IsNotNull<ArgumentException>(name, "name");
            Validator.IsNotNull<ArgumentException>(pInfo, "pInfo");
            Info = pInfo;
        }

        public string Name { get; private set; }
        public PropertyInfo Info { get; private set; }
        public IMethod GetMethod { get; internal set; }
        public IMethod SetMethod { get; internal set; }
    }
}
