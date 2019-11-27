using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace demo
{
    public interface IDemoTestAppService : IApplicationService
    {
        /// <summary>
        /// method use [Authorize]
        /// </summary>
        /// <returns></returns>
        Task<string> GetInfoWithAuthorizeAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> GetInfoAsync();
    }
}