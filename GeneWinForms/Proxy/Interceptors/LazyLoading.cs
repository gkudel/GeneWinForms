using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Extensions;
using Autofac;
using GeneWinForms.Repositories;

namespace GeneWinForms.Proxy.Interceptors
{
    internal class LazyLoading : AbstractInterceptor
    {
        private ILifetimeScope scope;
        public LazyLoading(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public override InterceptorIdentity Id
        {
            get { return InterceptorIdentity.LazyLoad; }
        }

        public override void Intercept(Castle.DynamicProxy.IInvocation invocation)
        {
            invocation.Proceed();
            if (invocation.ReturnValue == null)
            {
                Entity entity = invocation.InvocationTarget.CastToType<Entity>();
                if (entity.IsNotNull() || !invocation.Method.IsGetter())
                {
                    var mInfo = entity.TypeDesription.Methods[invocation.Method.ToString()];
                    if (mInfo != null && mInfo.RespositoryType.IsPresent())
                    {
                        var repository = (IRelatedRepository)scope.Resolve(mInfo.RespositoryType.Get());                        
                        invocation.ReturnValue = repository.Get(entity);
                        if (mInfo.Property.SetMethod != null)
                        {
                            if (!mInfo.Property.SetMethod.Access.Setter.IsPresent()) throw new InvalidOperationException();
                            mInfo.Property.SetMethod.Access.Setter.Get()(entity, invocation.ReturnValue);
                        }
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

        public override InterceptorProiority Priority
        {
            get
            {
                return InterceptorProiority.Low;
            }
        }
    }
}
