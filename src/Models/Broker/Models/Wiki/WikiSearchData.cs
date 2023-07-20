using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Models.Wiki
{
    public class WikiSearchData
    {
        public List<ArticleOrRubricSearchData> ArticleSearchData { get; }
        public List<ArticleOrRubricSearchData> RubricSearchData { get; }

        public WikiSearchData(
            List<ArticleOrRubricSearchData> articleSearchData,
            List<ArticleOrRubricSearchData> rubricSearchData)
        {
            ArticleSearchData = articleSearchData;
            RubricSearchData = rubricSearchData;
        }
    }
}
