using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty.ExpireDayConpositionClassPair
{
    public abstract class AbstractExpiredayBaseClass: IExpireDayConpositeClass
    {
        public int ID {get; set;}
        public DateTime CreatedDateTime { get; set; }
        private ExpireDayCompornent<AbstractExpiredayBaseClass> ExpireDayCompornent { get; set; }
        public DateTime? ExpiredDateTime() => ExpireDayCompornent.GetmethodT<DateTime, ExpireDayCompornent<AbstractExpiredayBaseClass>>();
        public void ExpiredDateTime(DateTime value) => ExpireDayCompornent.SetmethodT<DateTime, ExpireDayCompornent<AbstractExpiredayBaseClass>>(value);
    }
}
