using RepositoryCore.Interface.Abstract;
using RepositoryCore.Repository.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryCore.Repository.Models
{
    public class Post : BaseEntity
    {
        public Post() { }

        //public int ProfileId { get; set; }

        //[Required]
        //[RegularExpression("^[a-z0-9-]+$", ErrorMessage = "Slug format not valid.")]
        //[StringLength(160)]
        //public string Slug { get; set; }

        [Required]
        [StringLength(160)]
        public string Title { get; set; }
        [Required]
        [StringLength(450)]
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
        [StringLength(160)]
        public string Image { get; set; }

        public int PostViews { get; set; }

        public DateTime Published { get; set; }

        public bool IsFeatured { get; set; }
        public float Rating { get; set; }

        //public Profiles Profile { get; set; }
        public List<PostCategory> PostCategories { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
