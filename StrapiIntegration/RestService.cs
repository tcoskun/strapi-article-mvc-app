using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StrapiIntegration
{
    public class RestService: IRestService
    {
        private string EndPoint;
        private HttpClient Client;
        public RestService()
        {
            EndPoint = ConfigurationManager.AppSettings["StrapiEndPoint"];
            Client = new HttpClient();
        }
        public async Task<R> Get<R>(string path)
        {
            var url = $"{EndPoint}/{path}";
            HttpResponseMessage response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<R>(await response.Content.ReadAsStringAsync());
            }
            return default(R);
        }

        public async Task<R> Post<R>(string path, object request)
        {
            var url = $"{EndPoint}/{path}";
            HttpResponseMessage response = await Client.PostAsJsonAsync(url, request);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<R>(await response.Content.ReadAsStringAsync());
            }
            return default(R);
        }

    }
}
