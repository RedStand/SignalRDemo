using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.SignalRDemo
{
    public class ChatHub :Hub
    {
        public Task SendMsg(ChatMessageInfo info)
        {
            return Clients.All.SendAsync("Show", $"{info.UserName}:{info.Message}");
        }
    }

    public class ChatMessageInfo
    {
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}
