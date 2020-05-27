using System.Collections.Generic;
using RealTime.Data.Identity;

namespace RealTime.Data.Entities
{
    public class RoomMember
    {
        public string MemberId { get; set; }
        public ApplicationUser Member { get; set; }
        
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}