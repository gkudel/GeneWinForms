using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneWinForms.Tools
{
    public class Optional<V>
    {
        private readonly V v;

        public Optional(V v)
        {
            this.v = v;
        }

        public bool IsPresent()
        {
            return v != null;
        }

        public V Get()
        {
            if (v != null) return v;
            throw new InvalidOperationException();
        }

        public V OrElse(V item)
        {
            return IsPresent() ? v : item;
        }

        public static Optional<V> Of(V value)
        {
            return new Optional<V>(value);
        }
    }
}
