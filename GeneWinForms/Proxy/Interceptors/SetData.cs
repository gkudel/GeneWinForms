using System;
using GeneWinForms.Proxy;
using GeneWinForms.Extensions;
using Castle.DynamicProxy;

namespace GeneWinForms.Proxy.Interceptors
{
    internal class SetData : AbstractInterceptor
    {
        public override InterceptorIdentity Id
        {
            get { return InterceptorIdentity.SetData; }
        }

        public override void Intercept(IInvocation invocation)
        {
            Entity entity = invocation.InvocationTarget.CastToType<Entity>();
            if (entity.IsNotNull() || !invocation.Method.IsSetter() || !invocation.Arguments.IsEmpty())
            {
                var mInfo = entity.TypeDesription.Methods[invocation.Method.ToString()];
                if (mInfo != null)
                {
                    if (mInfo.Access.IsDao && mInfo.Access.Setter.IsPresent()) mInfo.Access.Setter.Get()(entity.DataObject, invocation.Arguments[0]);
                    else invocation.Proceed();
                }
                entity.OnPropertyChanged(invocation.Method.GetPropertyName());
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
