using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Department
{
    public interface ICreateDepartmentUserPublish
    {
        Guid DepartmentId { get; }
        Guid CreatedBy { get; }
        Guid UserId { get; }

        static object CreateObj(
            Guid departmentId,
            Guid createdBy,
            Guid userId)
        {
            return new
            {
                DepartmentId = departmentId,
                CreatedBy = createdBy,
                UserId = userId
            };
        }
    }
}

