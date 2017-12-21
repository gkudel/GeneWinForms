using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac.Core;
using GeneWinForms.Tools;
using Autofac;

namespace GeneWinForms.Extensions
{
    public static class ParameterExtensions
    {
        public static T FirstOrDeftaultNamed<T>(this IEnumerable<Parameter> @this, string name)
        {
            Validator.IsNotNull<ArgumentException>(@this, "@this");
            Validator.IsNotEmpty<ArgumentException>(name, "name");
            var namedParemeter =  @this.Where(p => p.IsTypeOf<NamedParameter>()).Select(p => p.CastToType<NamedParameter>()).FirstOrDefault();
            if (namedParemeter != null && namedParemeter.Value != null) return namedParemeter.Value.CastToType<T>();
            return default(T);
        }
    }
}
