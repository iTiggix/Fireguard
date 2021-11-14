using System;

namespace Core
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
    }
}
