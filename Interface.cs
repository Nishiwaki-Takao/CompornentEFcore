using System;
using System.Collections.Generic;
namespace ClassAsProperty
{

    public interface IClassAsProperty<T> where T : struct
    {
        public T Value { get; set; }

    }

    public interface IDicitinaryCAPValues
    {
        public int ID { get; set; }
    }

    public interface ICompoundClass
    { 
        public int ID { get; set; }
        public IDictionary<string, IDicitinaryCAPValues> Properties { get; set; } 
    }
    public interface

}
