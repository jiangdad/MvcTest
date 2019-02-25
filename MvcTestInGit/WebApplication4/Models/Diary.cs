using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Diary
    {
        [DisplayName("Title"),Required]
        public string Title { get; set; }
        [DisplayName("Content"), Required]
        public string Content { get; set; }
        [DisplayName("PubDate"), Required, DataType(DataType.DateTime)]
        public DateTime? PubDate { get; set; }
        [DisplayName("UserID")]
        public int UserId { get; set; }
        [DisplayName("user")]
        public virtual User user { get; set; }
    }
}