using LT.DigitalOffice.Models.Broker.Enums;
using LT.DigitalOffice.Models.Broker.Models.Image;
using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Image
{
    public interface ICreateImagesRequest
    {
        List<CreateImageData> Images { get; }
        ImageSource ImageSource { get; }
        public Guid CreatedBy { get; }

        static object CreateObj(List<CreateImageData> images, ImageSource imageSource, Guid createdBy)
        {
            return new
            {
                Images = images,
                ImageSource = imageSource,
                CreatedBy = createdBy
            };
        }
    }
}
