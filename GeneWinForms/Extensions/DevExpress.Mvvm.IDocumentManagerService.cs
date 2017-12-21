using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using GeneWinForms.Models.ViewModels.Base;
using GeneWinForms.Proxy;

namespace GeneWinForms.Extensions {
    public static class DocumentManagerServiceExtensions {

        public static IDocument ShowExistingEntityDocument<TEntity, TKey>(this IDocumentManagerService @this, object parentViewModel, TEntity entity, TKey key)
            where TEntity : Entity
        {
            IDocument document = FindEntityDocument<TEntity, TKey>(@this, key) ?? CreateDocument<TEntity>(@this, entity, parentViewModel);
            if(document != null)
                document.Show();
            return null;
        }

        public static IDocument FindEntityDocument<TEntity, TKey>(this IDocumentManagerService @this, TKey key)
            where TEntity : Entity
        {
            if (@this == null)
                return null;
            foreach (IDocument document in @this.Documents)
            {
                SingleEntityViewModel<TEntity, TKey> entityViewModel = document.Content as SingleEntityViewModel<TEntity, TKey>;
                if (entityViewModel != null && object.Equals(entityViewModel.Key, key))
                    return document;
            }
            return null;
        }

        static IDocument CreateDocument<TEntity>(IDocumentManagerService @this, object parameter, object parentViewModel)
        {
            if (@this == null)
                return null;
            var document = @this.CreateDocument(GetDocumentTypeName<TEntity>(), parameter, parentViewModel);
            document.Id = "_" + Guid.NewGuid().ToString().Replace('-', '_');
            document.DestroyOnClose = false;
            return document;
        }

        static string GetDocumentTypeName<TEntity>() {
            return typeof(TEntity).Name + "View";
        }
    }
}
