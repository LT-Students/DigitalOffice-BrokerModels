using LT.DigitalOffice.Models.Broker.Models.Image;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Image
{
    public interface IGetImagesResponse
    {
        List<ImageData> ImagesData { get; }

        static object CreateObj(List<ImageData> imagesData)
        {
            return new
            {
                ImagesData = imagesData
            };
        }
    }
}
