using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }

        [StringLength(100)]
        public string FacebookUrl { get; set; }
        [StringLength(100)]
        public string TwitterUrl { get; set; }

        [StringLength(100)]
        public string InstgramUrl { get; set; }

        [StringLength(100)]
        public string MailUrl { get; set; }
        [StringLength(100)]
        public string GitupUrl { get; set; }
        [StringLength(100)]
        public string Linkedin { get; set; }

    }
}
