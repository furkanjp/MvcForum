using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(50)]
        public String UserName { get; set; }
        [StringLength(50)]
        public String UserMail { get; set; }
        [StringLength(50)]
        public String Subject { get; set; }
        public String Mesagge { get; set; }
    }
}
