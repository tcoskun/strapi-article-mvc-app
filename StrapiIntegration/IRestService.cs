using System.Threading.Tasks;

namespace StrapiIntegration
{
    public interface IRestService
    {
        Task<R> Get<R>(string path);
        Task<R> Post<R>(string path, object request);
    }
}
