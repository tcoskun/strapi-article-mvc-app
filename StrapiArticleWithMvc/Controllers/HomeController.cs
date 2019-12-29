using StrapiIntegration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StrapiArticleWithMvc.Controllers
{
    public class HomeController : Controller
    {
        private IStrapiService strapiService;
        public HomeController(IStrapiService strapiService)
        {
            this.strapiService = strapiService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult >Publications(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                var articles = await strapiService.GetArticles();
                return View(articles);
            }
            else
            {
                var articles = await strapiService.GetArticlesByUrl(id);
                return View("Publication", articles.FirstOrDefault());
            }
        }
    }
}