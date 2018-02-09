using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MessageMe.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string number1, string number2)
        {
            int mult = int.Parse(number1) * int.Parse(number2);
            // Call the addNewMessageToPage method to update clients.
            string msg = string.Format("The multiplication of {0}*{1} is {2}", number1, number2, mult);

            Clients.All.addNewMessageToPage(name, msg);
        }

        public void SendBroadcastMessage(string message)
        {
            // Call the addMessage methods on all clients
            Clients.All.addBroadcastMessage(message);
        }
    }
}