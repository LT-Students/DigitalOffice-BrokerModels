using LT.DigitalOffice.Models.Broker.Models;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Search
{
    public interface ISearchResponse
    {
        List<SearchInfo> Entities { get; }

        static object CreateObj(List<SearchInfo> entities)
        {
            return new
            {
                Entities = entities
            };
        }
    }
}
