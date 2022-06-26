using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace e_commerce_app_with_blazor.Service
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
    }
}
