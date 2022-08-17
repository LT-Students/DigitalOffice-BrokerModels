using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Requests.TextTemplate
{
  public interface IGetTextTemplateRequest
  {
    Guid? EndpointId { get; }
    TemplateType TemplateType { get; }
    string Locale { get; }

    static object CreateObj(Guid? endpointId, TemplateType templateType, string locale)
    {
      return new
      {
        EndpointId = endpointId,
        TemplateType = templateType,
        Locale = locale
      };
    }
  }
}
