using RealTime.Data.Identity;

namespace RealTime.Data.Entities
{
    public class Message : Entity
    {
        public string Content { get; set; }

        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
        
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}