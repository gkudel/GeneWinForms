using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm.DataAnnotations;
using GeneWinForms.Models.ViewModels.Base;
using entiy = GeneWinForms.Models;

namespace GeneWinForms.Models.ViewModels.Test
{
    [POCOViewModel]
    public class TestViewModel : SingleEntityViewModel<entiy.Test, long>
    {
        public TestViewModel()
            : base(e => e.Recid)
        { }
    }
}
