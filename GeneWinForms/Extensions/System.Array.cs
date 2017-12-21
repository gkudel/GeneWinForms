using System;

namespace GeneWinForms.Extensions
{
    public static class ArrayExtensions
    {
        public static bool IsNotEmpty(this Array @this)
        {
            return @this != null && @this.Length > 0;
        }

        public static bool IsEmpty(this Array @this)
        {
            return @this == null || @this.Length == 0;
        }
    }
}
