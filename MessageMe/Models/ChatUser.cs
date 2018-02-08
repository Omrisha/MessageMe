using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageMe.Models
{
    public class ChatUser
    {
        public string UserName { get; set; }
        public DateTime LoogedOnTime { get; set; }
        public DateTime LastPing { get; set; }
    }
}