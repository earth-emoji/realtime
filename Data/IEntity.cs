using System;

namespace RealTime.Data.Entities
{
    public interface IEntity
    {
        long Id { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
    }
}