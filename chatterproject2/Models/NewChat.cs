using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace chatterproject2.Models
{
    public class NewChat
    {
        [Key]
        public int ChatID { get; set; }
        public string Chatter { get; set; }
        public DateTime Date { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}