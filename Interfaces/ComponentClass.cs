using System;
using System.Collections.Generic;
namespace ClassAsProperty
{

    public interface ICompornentClass<T> where T : struct
    {
        public int ID { get; set; }
        public T Value { get; set; }

    }

}
