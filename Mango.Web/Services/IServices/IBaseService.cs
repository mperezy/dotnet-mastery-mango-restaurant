using System;
using System.Threading.Tasks;
using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto _responseDto { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}