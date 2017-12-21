using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Dao;
using GeneWinForms.Proxy;
using Autofac;

namespace GeneWinForms.Models
{
    public class Specimen : GenericEntity<SpecimnenDao>
    {
        public Specimen()
            : base()
        { }

        public Specimen(SpecimnenDao dao)
            : base(dao)
        {
        }

        public virtual long Recid { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
    }
}
