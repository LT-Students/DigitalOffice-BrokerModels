using DigitalOffice.Models.Broker.Models.Wiki;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Search
{
    public interface ISearchWikiResponse
    {
        List<ArticleSearchData> Article { get; }
        List<RubricSearchData> Rubric { get; }
        int TotalCount { get; }

        static object CreateObj(List<ArticleSearchData> articles, List<RubricSearchData> rubrics)
        {
            return new
            {
                Article = articles,
                Rubric = rubrics,
                TotalCount = articles.Count + rubrics.Count
            };
        }
    }
}
