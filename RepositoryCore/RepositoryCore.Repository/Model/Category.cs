using RepositoryCore.Interface.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryCore.Repository.Models
{
    public class Category : BaseEntity
    {
        //[Required]
        //[StringLength(160)]
        //[RegularExpression("^[a-z0-9-]+$", ErrorMessage = "Slug format not valid.")]
        //public string Slug { get; set; }

        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [StringLength(450)]
        public string Description { get; set; }
        [StringLength(160)]
        public string ImgSrc { get; set; }
        public int Rank { get; set; }

        public List<PostCategory> PostCategories { get; set; }
    }
}
