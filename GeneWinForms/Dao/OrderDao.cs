using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Dao
{
    public class OrderDao
    {
        public long Recid { get; set; }
        public string OrderNumber { get; set; }
        public List<TestDao> Tests { get; set; }
        public List<SpecimnenDao> Specimens { get; set; }
    }
}
