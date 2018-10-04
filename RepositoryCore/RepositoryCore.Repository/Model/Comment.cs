using RepositoryCore.Interface.Abstract;
using RepositoryCore.Repository.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RepositoryCore.Repository.Model
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Added = DateTime.Now;
        }
        
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        //public string WebSite { get; set; }

        [Required]
        public long PostId { get; set; }

        public Post Post { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime Added { get; set; }
    }
}
