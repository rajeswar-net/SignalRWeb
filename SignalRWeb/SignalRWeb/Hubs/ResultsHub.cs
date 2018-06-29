using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRWeb.Hubs
{
    public class ResultsHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello("Welcome from SignalR!");
            
        }
        public void SendMessage(string message)
        {
            string completeMessage = string.Concat(Context.ConnectionId, " has registered the following message: ", message);
            Clients.All.registerMessage(completeMessage);
        }
    }
}