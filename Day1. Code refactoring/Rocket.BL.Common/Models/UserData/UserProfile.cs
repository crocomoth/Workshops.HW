using System.Collections.Generic;
using Rocket.BL.Common.Models.PersonalArea;

namespace Rocket.BL.Common.Models.UserData
{
    public class UserProfile
    {
        /// <summary>
        /// Id пользователя.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Относительный путь к аватаре пользователя.
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Коллекция e-mail адресов пользователя.
        /// </summary>
        public ICollection<Email> Emails { get; set; }

        /// <summary>
        /// Персональный список релизов в виде списка жанров TV. 
        /// </summary>
        public ICollection<Genre> Genres { get; set; }

        /// <summary>
        /// Персональный список релизов в виде списка музыкальных жанров. 
        /// </summary>
        public ICollection<MusicGenre> MusicGenre { get; set; }
    }
}