using System;

namespace DigitalOffice.Models.Broker.Models.Wiki
{
    public class ArticleOrRubricSearchData
    {
        public Guid Id { get; }
        public string Name { get; }

        public ArticleOrRubricSearchData(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
