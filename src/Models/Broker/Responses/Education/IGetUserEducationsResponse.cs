using LT.DigitalOffice.Models.Broker.Models.Education;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Education
{
    public interface IGetUserEducationsResponse
    {
        List<EducationData> Educations { get; }
       
        static object CreateObj(
            List<EducationData> educations)
        {
            return new
            {
                Educations = educations
            };
        }
    }
}
