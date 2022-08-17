using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Image
{
    public interface ICreateImagesResponse
    {
        List<Guid> ImagesIds { get; }

        static object CreateObj(List<Guid> imagesIds)
        {
            return new
            {
                ImagesIds = imagesIds
            };
        }
    }
}
