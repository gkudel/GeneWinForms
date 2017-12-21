using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using GeneWinForms.Dao;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using GeneWinForms.Proxy;
using System.Collections.ObjectModel;
using GeneWinForms.Extensions;
using Autofac;
using GeneWinForms.Proxy.Attributes;
using GeneWinForms.Repositories;

namespace GeneWinForms.Models
{
    public class Order : GenericEntity<OrderDao>
    {
        private IList<Test> tests;

        public Order(ILifetimeScope scope, OrderDao dao)
            : base(dao)
        {
        }

        public virtual long Recid { get; set; }
        public virtual string OrderNumber { get; set; }
        [LazyLoading(RepositoryType = typeof(IRelatedRepository<Order, Test>))]
        public virtual IList<Test> Tests {
            get
            {
                return tests;
            }
            set
            {
                tests = value;
            }
        }
        [LazyLoading]
        public virtual IList<Specimen> Specimens { get; set; }
    }
}
