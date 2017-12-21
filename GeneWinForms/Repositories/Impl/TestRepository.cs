using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Models;
using GeneWinForms.Extensions;
using System.ComponentModel;
using Autofac;
using GeneWinForms.Dao;

namespace GeneWinForms.Repositories.Impl
{
    public class TestRepository : AbstractReletedRepository<Order, Test>
    {
        private ILifetimeScope scope;
        public TestRepository(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public override IList<Test> Get(Order parent)
        {
            if (parent.Dao.Tests == null)
            {
                parent.Dao.Tests = new List<TestDao> { 
                    new TestDao() { Code = "Frax", Name = "FraxName"},
                    new TestDao() { Code = "Sma", Name = "SmaName"}
                };
            }
            return new BindingList<Test>(parent.Dao.Tests.OrEmpty().Select(testDao => scope.Resolve<Test>(new NamedParameter("dao", testDao))).ToList());
        }
    }
}
