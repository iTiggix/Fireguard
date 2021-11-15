namespace Core.Domain.Roles
{
    public class Role : BaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип роли
        /// </summary>
        public RoleType Type { get; set; }
    }
}
