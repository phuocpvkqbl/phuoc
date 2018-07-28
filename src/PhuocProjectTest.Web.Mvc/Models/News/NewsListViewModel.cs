using System.Collections.Generic;
using PhuocProjectTest.New.Dto;
using PhuocProjectTest.Roles.Dto;

namespace PhuocProjectTest.Web.Models.News
{
    public class NewsListViewModel
    {
        public IReadOnlyList<NewsDto> News { get; set; }
    }
}
