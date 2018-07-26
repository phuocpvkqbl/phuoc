using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using PhuocProjectTest;

namespace PhuocProjectTest.New.Dto
{
    [AutoMapFrom(typeof(News))]
    public class NewsDto:EntityDto<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
