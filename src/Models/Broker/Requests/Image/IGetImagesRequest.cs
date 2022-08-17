using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Image
{
    public interface IGetImagesRequest
    {
        List<Guid> ImagesIds { get; }
        ImageSource ImageSource { get; }

        static object CreateObj(List<Guid> imagesIds, ImageSource imageSource)
        {
            return new
            {
                ImagesIds = imagesIds,
                ImageSource = imageSource
            };
        }
    }
}
