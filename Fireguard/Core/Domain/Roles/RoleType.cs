namespace Core.Domain.Roles
{
    public enum RoleType
    {
        /// <summary>
        /// Гость
        /// </summary>
        Guest = 0,

        /// <summary>
        /// Авторизированный пользователь
        /// </summary>
        User = 1,

        /// <summary>
        /// Администратор
        /// </summary>
        Administrator = 2
    }
}
