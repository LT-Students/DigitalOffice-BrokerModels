using System;

namespace LT.DigitalOffice.Models.Broker.Requests.Company
{
  public interface ICheckContractSubjectExistenceRequest
  {
    public Guid ContractSubjectId { get; set; }

    static object CreateObj(Guid contractSubjectId)
    {
      return new
      {
        ContractSubjectId = contractSubjectId
      };
    }
  }
}
