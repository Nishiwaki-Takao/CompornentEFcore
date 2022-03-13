using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty
{
    public static class ClassAsPropertyMethodBase
    {

        public static T? GetmethodT<T, T2>(this T2 TargetPoperty) where T : struct where T2 : ICompornentClass<T>
        {
            return TargetPoperty?.Value;
        }

        public static void SetmethodT<T, T2>(this T2 TargetProperty, T value) where T : struct where T2 : ICompornentClass<T>, new()
        {
            if (TargetProperty is null)
            { TargetProperty = new T2(); }
            TargetProperty.Value = value;
        }
    }
}
