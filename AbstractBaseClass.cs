using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty
{
    public abstract class ClassAsPropertyABC<T> : IClassAsProperty<T> where T : struct
    {
        public int ID { get; set; }
        public T Value { get; set; }
    }
}
