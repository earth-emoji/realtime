using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RealTime.Data;
using RealTime.Data.Entities;

namespace RealTime.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private string _loginName => Context.User.Identity.Name;

        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}