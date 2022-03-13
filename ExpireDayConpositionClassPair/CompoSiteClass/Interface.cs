using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsProperty.ExpireDayConpositionClassPair
{
    public interface IExpireDayConpositeClass
    {
        public int ID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ExpiredDateTime();
        public void ExpiredDateTime(DateTime value);

    }
}
