using MagicVilla_Web.Models;

namespace MagicVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        // Generic Base Service
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apirequest);    //  Use to send API call to call our API
    }
}
