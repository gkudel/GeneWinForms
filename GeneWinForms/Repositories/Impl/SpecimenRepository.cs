using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Models;
using Autofac;
using GeneWinForms.Dao;
using GeneWinForms.Extensions;
using System.ComponentModel;

namespace GeneWinForms.Repositories.Impl
{
    public class SpecimenRepository : AbstractReletedRepository<Order, Specimen>
    {
        private ILifetimeScope scope;
        public SpecimenRepository(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public override IList<Specimen> Get(Order parent)
        {
            if (parent.Dao.Specimens == null)
            {
                parent.Dao.Specimens = new List<SpecimnenDao> { 
                    new SpecimnenDao() { Code = "BLOOD", Name = "Blood"}
                };
            }
            return new BindingList<Specimen>(parent.Dao.Specimens.OrEmpty().Select(specimenDao => scope.Resolve<Specimen>(new NamedParameter("dao", specimenDao))).ToList());
        }

    }
}
