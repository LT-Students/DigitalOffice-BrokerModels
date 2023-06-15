using System;

namespace DigitalOffice.Models.Broker.Models.News
{
    public class NewsSearchData
    {
        public Guid Id { get; }
        public string Preview { get; }

        public NewsSearchData(Guid id, string preview)
        {
            Id = id;
            Preview = preview;
        }
    }
}
