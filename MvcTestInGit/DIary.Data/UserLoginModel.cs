using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIary.Data
{
    public class UserLoginModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Status { get; set; }

        public string Msg { get; set; }
    }
}