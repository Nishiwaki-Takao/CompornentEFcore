using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty
{
    public static class ClassAsPropertyMethodBase
    {

        public static T? GetmethodT<T, T2>(ref T2 TargetPoperty) where T : struct where T2 : IClassAsProperty<T>
        {
            return TargetPoperty?.Value;
        }

        public static void SetMetgidT<T, T2>(T value, ref T2 TargetProperty) where T : struct where T2 : IClassAsProperty<T>, new()
        {
            if (TargetProperty is null)
            { TargetProperty = new T2(); }
            TargetProperty.Value = value;
        }
    }
}
