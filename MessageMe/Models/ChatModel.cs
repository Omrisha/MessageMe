using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageMe.Models
{
    public class ChatModel
    {
        public List<ChatUser> ChatUsers { get; set; }
        public List<ChatMessage> ChatMessages { get; set; }

        public ChatModel()
        {
            ChatUsers = new List<ChatUser>();

            ChatMessages = new List<ChatMessage>();

            ChatMessages.Add(new ChatMessage
            {
                Message = "The server started at " + DateTime.Now
            });
        }
    }
}