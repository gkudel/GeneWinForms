using System;
namespace GeneWinForms.Tools
{
    public static class Validator
    {
        public static void IsNotNull<T>(object o, string paramName) where T : Exception
        {
            if (o == null) throw (T) Activator.CreateInstance(typeof (T), args: new object[] {paramName});
        }

        public static void IsNotEmpty<T>(string o, string paramName) where T : Exception
        {
            if (o == null || string.Empty.Equals(o)) throw (T)Activator.CreateInstance(typeof(T), args: new object[] { paramName });
        }
    }
}
