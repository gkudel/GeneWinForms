using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm.DataAnnotations;
using entiy = GeneWinForms.Models;
using GeneWinForms.Models.ViewModels.Base;

namespace GeneWinForms.Models.ViewModels.Specimen
{
    [POCOViewModel]
    public class SpecimenViewModel : SingleEntityViewModel<entiy.Specimen, long>
    {
        public SpecimenViewModel()
            : base(e => e.Recid)
        { }
    }
}
