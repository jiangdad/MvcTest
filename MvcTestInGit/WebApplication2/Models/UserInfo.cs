using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "用户名必须为{2}到{1}个字符")]
        public string Name { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        [Display(Name = "密码")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "密码必须为{2}到20个字符")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
        [Display(Name = "邮箱")]
        [Required(ErrorMessage="邮箱必填")]
        [RegularExpression(@"^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$",
ErrorMessage = "请输入正确的Email格式\n示例：abc@123.com")]
        public string Email { get; set; }
        public int Rank { get; set; }
        public DateTime RegisterTime { get; set; }

    }
}