using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models
{
    public class SearchInfo<T>
    {
        public List<T> Values { get; }
        public int TotalCount { get; }

        public SearchInfo(List<T> values)
        {
            Values = values;
            TotalCount = values.Count;
        }
    }
}
