using System;

namespace ComiCore.Model
{
    public interface IEntity
    {
        bool Deleted { get; set; }
        Guid UniqueId { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public Guid UniqueId { get; set; } = Guid.NewGuid();
        public bool Deleted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
    }

    public abstract class BaseEntity : Entity
    {
        public int Id { get; set; }
    }
}
