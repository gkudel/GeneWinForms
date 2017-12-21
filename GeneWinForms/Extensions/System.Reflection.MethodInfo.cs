
using System.Linq;
using System.Reflection;
using System;

namespace GeneWinForms.Extensions
{
    public static class MethodInfoExtensions
    {
        public static bool IsGetter(this MethodInfo @this)
        {
            return @this.Name.StartsWith("get_") && !@this.GetParameters().Any() && @this.ReturnType != typeof(void);
        }

        public static bool IsSetter(this MethodInfo @this)
        {
            return @this.Name.StartsWith("set_") && @this.GetParameters().Length == 1 && @this.ReturnType == typeof(void);
        }

        public static string GetPropertyName(this MethodInfo @this)
        {
            if (!IsSetter(@this)) throw new InvalidOperationException();
            return @this.Name.Substring(4, @this.Name.Length - 4);
        }
    }
}
