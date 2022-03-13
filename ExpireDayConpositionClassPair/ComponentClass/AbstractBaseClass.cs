using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty.ExpireDayConpositionClassPair
{
    public class ExpireDayCompornent<T>: ICompornentClass<DateTime> where T : AbstractExpiredayBaseClass
    {
        public ExpireDayCompornent() { Value = System.DateTime.Now; }
        public ExpireDayCompornent(DateTime value) { Value = value; }
        public int ID { get; set; }
        public DateTime Value { get; set; }
        public T ExpiredComposteNavigation { get; set; }
    }
}
