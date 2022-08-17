using LT.DigitalOffice.Models.Broker.Enums;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Publishing.Subscriber.Image
{
    public interface IRemoveImagesPublish
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
