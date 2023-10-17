using System;

namespace DigitalOffice.Models.Broker.Requests.Survey;

public interface IGetSurveyUsersRequest
{
  Guid SurveyId { get; }

  static object CreateObj(Guid surveyId)
  {
    return new
    {
      SurveyId = surveyId
    };
  }
}
