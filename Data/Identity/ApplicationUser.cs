using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using RealTime.Data.Entities;

namespace RealTime.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Message> Messages { get; set; }
        public ICollection<RoomMember> Rooms { get; set; }
    }
}