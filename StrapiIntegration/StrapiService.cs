using StrapiIntegration.Models;
using System.Threading.Tasks;

namespace StrapiIntegration
{
    public class StrapiService: IStrapiService
    {
        private IRestService restService;

        public StrapiService(IRestService restService)
        {
            this.restService = restService;
        }

        public Task<Article[]> GetArticles()
        {
            return restService.Get<Article[]>("articles");
        }

        public Task<Article> GetArticle(int id)
        {
            return restService.Get<Article>($"articles/{id}");
        }

        public Task<Article[]> GetArticlesByUrl(string url)
        {
            return restService.Get<Article[]>($"articles?Url={url}");
        }
    }
}
