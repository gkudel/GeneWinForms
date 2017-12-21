using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Extensions;
using Castle.DynamicProxy;

namespace GeneWinForms.Proxy.Interceptors
{
    internal class GetData : AbstractInterceptor
    {
        public override InterceptorIdentity Id
        {
            get { return InterceptorIdentity.GetData; }
        }

        public override void Intercept(IInvocation invocation)
        {
            Entity entity = invocation.InvocationTarget.CastToType<Entity>();
            if (entity.IsNotNull() || !invocation.Method.IsGetter())
            {
                var mInfo = entity.TypeDesription.Methods[invocation.Method.ToString()];
                if (mInfo != null)
                {
                    if (mInfo.Access.IsDao && mInfo.Access.Getter.IsPresent()) invocation.ReturnValue = mInfo.Access.Getter.Get()(entity.DataObject);
                    else invocation.Proceed();
                }
                else 
                {
                    throw new InvalidOperationException();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
