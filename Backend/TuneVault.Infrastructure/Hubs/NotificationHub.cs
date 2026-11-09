using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TuneVault.Application.Common.Interfaces;

namespace TuneVault.Infrastructure.Hubs
{
    [Authorize]
    public class NotificationHub : Hub, INotificationHub
    {
        public async Task SendNotification(string userId, object notification)
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", notification);
        }
    }
}
