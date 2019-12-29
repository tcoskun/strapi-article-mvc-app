using System.Threading.Tasks;
using StrapiIntegration.Models;

namespace StrapiIntegration
{
    public interface IStrapiService
    {
        Task<Article[]> GetArticles();
        Task<Article> GetArticle(int id);
        Task<Article[]> GetArticlesByUrl(string url);
    }
}
