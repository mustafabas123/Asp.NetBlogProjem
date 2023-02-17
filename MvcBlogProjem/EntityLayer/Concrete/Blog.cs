using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Image { get; set; }
        public DateTime BlogDate { get; set; }

        [StringLength(500)]
        public string BlogDescription { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Comment> Comments { get; set;}
        public int BlogRating { get; set; }
    }
}
