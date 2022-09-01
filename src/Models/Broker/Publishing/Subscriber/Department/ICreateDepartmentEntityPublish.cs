using System;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Department
{
    public interface ICreateDepartmentUserPublish
    {
        Guid UserId { get; }
        Guid DepartmentId { get; }
        Guid CreatedBy { get; }
        bool IsActive { get; }

        static object CreateObj(
            Guid userId,
            Guid departmentId,
            Guid createdBy,
            bool isActive = false)
        {
            return new
            {
                UserId = userId,
                DepartmentId = departmentId,
                CreatedBy = createdBy,
                IsActive = isActive
            };
        }
    }
}

