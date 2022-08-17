using LT.DigitalOffice.Models.Broker.Models.Company;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Company
{
    public interface IGetCompaniesResponse
    {
        List<CompanyData> Companies { get; set; }

        static object CreateObj(
            List<CompanyData> companies)
        {
            return new
            {
                Companies = companies
            };
        }
    }
}
