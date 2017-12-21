using System;
using System.Reflection;
using Castle.DynamicProxy;
using GeneWinForms.Extensions;

namespace GeneWinForms.Proxy
{
    public class EntityInterceptorGenerationHook : IProxyGenerationHook
    {
        #region IProxyGenerationHook
        public void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
        {
        }

        public bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
        {
            return Entity.GetDescription(type).Methods.ContainsKey(methodInfo.ToString());
        }

        public void NonVirtualMemberNotification(Type type, MemberInfo memberInfo)
        {
        }

        public void MethodsInspected()
        {            
        }
        #endregion IProxyGenerationHook

        #region Equals & GetHashCode
        public override bool Equals(object obj)
        {
            return obj is EntityInterceptorGenerationHook;
        }

        public override int GetHashCode()
        {
            // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
            return base.GetHashCode();
        }
        #endregion Equals & GetHashCode
    }
}
