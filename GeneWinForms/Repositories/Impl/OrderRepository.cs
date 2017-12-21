using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Models;
using Autofac;
using GeneWinForms.Dao;

namespace GeneWinForms.Repositories.Impl
{
    public class OrderRepository : IRepository<Order, long>
    {
        private ILifetimeScope lifeTimeScope;
        public OrderRepository(ILifetimeScope lifeTimeScope)
        {
            this.lifeTimeScope = lifeTimeScope;
        }

        public Order Get(long key)
        {
            OrderDao dao = new OrderDao()
            {
                OrderNumber = "AAA17005689",
                Recid = 1024
            };
            if (dao.Recid != key) throw new InvalidOperationException();
            return lifeTimeScope.Resolve<Order>(new NamedParameter("dao", dao));
        }
    }
}
