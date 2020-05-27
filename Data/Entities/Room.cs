using System.Collections.Generic;
using RealTime.Data.Identity;

namespace RealTime.Data.Entities
{
    public class Room : Entity
    {
        public string Name { get; set; }

        // public byte[] Salt { get; set; }
        // public string Password { get; set; }

        public string HostId { get; set; }
        public ApplicationUser Host { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<RoomMember> Members { get; set; }
    }
}