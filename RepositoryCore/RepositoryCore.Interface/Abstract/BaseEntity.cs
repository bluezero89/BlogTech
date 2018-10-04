using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryCore.Interface.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
