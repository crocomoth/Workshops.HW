using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rocket.BL.Common.Models.Subscription
{
    /// <summary>
    /// Представляет базовую модель ресурсов, на которые возможна подписка
    /// </summary>
    public abstract class Subscribable
    {
        /// <summary>
        /// Уникальный идентификатор ресурса
        /// </summary>
        public int Id { get; set; }

        //TODO Is this field needed? move it to db-level?helper?
        /// <summary>
        /// Коллекция пользователей подписанных на данный ресурс
        /// </summary>
        /// This class needs to be fixed. Fixing it provokes a chain changed o project leading to unpredictable changes.
        public ICollection<User.User> Users { get; set; } = new Collection<User.User>();
    }
}
