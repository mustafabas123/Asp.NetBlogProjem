﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [StringLength(150)]
        public string AuthorImage { get; set; }

        [StringLength(500)]
        public string AuthorDetail { get; set; }
        public ICollection<Blog> Blogs { get; set;}


        [StringLength(50)]
        public string AuthorTitle { get; set; }
        [StringLength(50)]
        public string AuthorMail { get; set; }
        [StringLength(50)]
        public string AuthorPassword { get; set; }

        [StringLength(50)]
        public string AuthorPhone { get; set; }

        [StringLength(250)]
        public string AuthorShortAbout { get; set; }
    }
}
