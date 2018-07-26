using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using PhuocProjectTest.Authorization.Roles;

namespace PhuocProjectTest.New.Dto
{
    [AutoMapTo(typeof(News))]
   public class CreateNewsDto
    {
        public const int MaxTitleLength = 250;
        [StringLength(MaxTitleLength)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int VisibilityStatus { get; set; }
    }
}
