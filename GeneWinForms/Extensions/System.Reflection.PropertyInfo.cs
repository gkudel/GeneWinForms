using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using GeneWinForms.Tools;
using System.Linq.Expressions;

namespace GeneWinForms.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static string GetGetSignature(this PropertyInfo @this)
        {
            if(!@this.PropertyType.IsGenericType) return "get " + @this.PropertyType.Name + " " + @this.Name;
            return "get " + @this.PropertyType.Name + "<" + string.Join(",", @this.PropertyType.GetGenericArguments().Select(t => t.Name).ToList())  + "> " + @this.Name;
        }

        public static string GetSetSignature(this PropertyInfo @this)
        {
            if (!@this.PropertyType.IsGenericType) return "set " + @this.PropertyType.Name + " " + @this.Name;
            return "set " + @this.PropertyType.Name + "<" + string.Join(",", @this.PropertyType.GetGenericArguments().Select(t => t.Name).ToList()) + "> " + @this.Name;
        }

        public static bool HasCustomAttribute<TAttribute>(this PropertyInfo @this) where TAttribute : Attribute
        {
            return @this.GetCustomAttributes(typeof(TAttribute), true).IsNotEmpty();
        }

        public static TAttribute GetCustomAttribute<TAttribute>(this PropertyInfo @this) where TAttribute : Attribute
        {
            return (TAttribute)@this.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault();
        }

        public static Func<object, object> CreateGetter(this PropertyInfo @this)
        {
            Validator.IsNotNull<InvalidOperationException>(@this, "propertyInfo");
            ParameterExpression obj = Expression.Parameter(typeof(object));
            Expression convertObj = Expression.Convert(obj, @this.ReflectedType);
            return Expression.Lambda<Func<object, object>>(Expression.Convert(Expression.MakeMemberAccess(convertObj, @this), typeof(object)), obj).Compile();
        }

        public static Action<object, object> CreateSetter(this PropertyInfo @this)
        {
            Validator.IsNotNull<InvalidOperationException>(@this, "propertyInfo");
            ParameterExpression obj = Expression.Parameter(typeof(object));
            Expression convertObj = Expression.Convert(obj, @this.ReflectedType);
            ParameterExpression value = Expression.Parameter(typeof(object));
            DefaultExpression defaultvalue = Expression.Default(@this.PropertyType);
            return Expression.Lambda<Action<object, object>>(Expression.TryCatch(
                    Expression.Assign(Expression.MakeMemberAccess(convertObj, @this), Expression.Convert(value, @this.PropertyType)),
                    Expression.Catch(typeof(InvalidOperationException), Expression.Assign(Expression.MakeMemberAccess(convertObj, @this), defaultvalue)),
                    Expression.Catch(typeof(ArgumentNullException), Expression.Assign(Expression.MakeMemberAccess(convertObj, @this), defaultvalue))),
                obj, value).Compile();
        }
    }
}
