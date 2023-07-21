using System;

namespace DigitalOffice.Models.Broker.Models.Wiki
{
    public class ArticleSearchData
    {
        public Guid Id { get; }
        public string Name { get; }

        public ArticleSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
