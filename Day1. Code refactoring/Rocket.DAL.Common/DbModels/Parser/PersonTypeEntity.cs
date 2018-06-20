using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.Parser
{
    public class PersonTypeEntity : IBaseEntity
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public ICollection<PersonEntity> Persons { get; set; }
        public int Id { get; set; }
    }
}
