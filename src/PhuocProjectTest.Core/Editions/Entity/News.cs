using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhuocProjectTest
{
    [Table("News")]
    public class News : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public DateTime PostDate { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public News()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
