using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using GeneWinForms.Proxy;

namespace GeneWinForms.Extensions
{
    public static class IDialogServiceExtensions
    {
        public static MessageResult ShowDialog<TEntity>(this IDialogService @this, MessageButton dialogButtons, TEntity entity, object parentViewModel)
            where TEntity : Entity
        {
            return @this.ShowDialog(dialogButtons, GetDialogTitle<TEntity>(), GetDialogTypeName<TEntity>(), entity, parentViewModel);
        }

        static string GetDialogTypeName<TEntity>()
        {
            return typeof(TEntity).Name + "View";
        }

        static string GetDialogTitle<TEntity>()
        {
            return "Edit " + typeof(TEntity).Name;
        }
    }
}
