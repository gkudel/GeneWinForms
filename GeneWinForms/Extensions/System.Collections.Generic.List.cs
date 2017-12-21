using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Extensions
{
    public static class ListExtensions
    {
        public static List<T> OrEmpty<T>(this List<T> @this)
        {
            if (@this != null) return @this;
            return new List<T>();
        }
    }
}
