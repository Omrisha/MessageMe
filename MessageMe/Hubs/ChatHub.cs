using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MessageMe.Models;
using Microsoft.AspNet.SignalR;

namespace MessageMe.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string number1, string number2)
        {
            int mult = int.Parse(number1) * int.Parse(number2);
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, mult.ToString());
        }

        public void SendMessage(string message)
        {
            // Call the addMessage methods on all clients
            Clients.All.addMessage(message);
        }
    }
}