using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(500)]
        public string AboutDescription1 { get; set; }

        [StringLength(500)]
        public string AboutDescription2 { get; set; }

        [StringLength(150)]
        public string ImageUrl1 { get; set; }

        [StringLength(150)]
        public string ImageUrl2 { get; set;}
    }
}
