using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using PhuocProjectTest.Authorization;
using PhuocProjectTest.Authorization.Roles;
using PhuocProjectTest.Authorization.Users;
using PhuocProjectTest.New.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuocProjectTest.New
{
    [AbpAuthorize()]
    public class NewsAppService: AsyncCrudAppService<News,NewsDto,int, PagedResultRequestDto, CreateNewsDto,NewsDto>
    {
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        public NewsAppService(IRepository<News> repository, RoleManager roleManager, UserManager userManager)
           : base(repository)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
    }
}
