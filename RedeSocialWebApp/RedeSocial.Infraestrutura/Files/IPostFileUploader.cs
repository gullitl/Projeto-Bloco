using Microsoft.AspNetCore.Http;
using System.IO;

namespace RedeSocial.Infraestrutura.Files
{
    public interface IPostFileUploader
    {
        string UploadFile(IFormFile file, string fileName);
    }
}
