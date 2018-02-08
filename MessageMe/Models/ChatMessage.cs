using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageMe.Models
{
    public class ChatMessage
    {
        public ChatUser User { get; set; }
        public DateTime SentTime { get; set; }
        public string Message { get; set; }
    }
}