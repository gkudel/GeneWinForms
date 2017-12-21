using System;
using System.Linq.Expressions;

namespace GeneWinForms.Extensions
{
    public static class ObjectExtensions
    {
        public static T CastToType<T>(this object @this) 
        {
            if (@this != null && IsTypeOf<T>(@this))
            {
                return (T)@this;
            }
            throw new InvalidCastException();
        }

        public static bool IsTypeOf<T>(this object @this) 
        {
            return @this is T;
        }

        public static bool IsNotNull(this object @this)
        {
            return @this != null;
        }

        public static void Invoke<TType>(this object @this, Expression<Action<TType>> methodselector) where TType : class
        {
            if (@this != null && IsTypeOf<TType>(@this))
            {
                methodselector.Compile()((TType)@this);
            }
        }

        public static void Invoke<TType, TParam>(this object @this, Expression<Action<TType, TParam>> methodselector, TParam tParam) where TType : class
        {
            if (@this != null && IsTypeOf<TType>(@this))
            {
                methodselector.Compile()((TType)@this, tParam);
            }
        }
    }
}
