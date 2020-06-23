using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class ServerHub : Hub
    {
        public void SendDataToServer(string data)
        {
            Clients.All.getDataFromServer(data);
        }
      
    }
}