using DigitalOffice.Models.Broker.Models.Image;
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
        public ResizeParameters ResizeParameters { get; }
        public Guid CreatedBy { get; }

        static object CreateObj(
            List<CreateImageData> images,
            ImageSource imageSource,
            ResizeParameters resizeParameters,
            Guid createdBy)
        {
            return new
            {
                Images = images,
                ImageSource = imageSource,
                ResizeParameters = resizeParameters,
                CreatedBy = createdBy
            };
        }
    }
}
