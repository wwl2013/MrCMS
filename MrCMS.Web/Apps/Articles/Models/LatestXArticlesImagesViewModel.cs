using System.Collections.Generic;
using MrCMS.Web.Apps.Articles.Pages;

namespace MrCMS.Web.Apps.Articles.Models
{
    public class LatestXArticlesImagesViewModel
    {
        public IList<Article> Articles { get; set; }
        public string Title { get; set; }
    }
}