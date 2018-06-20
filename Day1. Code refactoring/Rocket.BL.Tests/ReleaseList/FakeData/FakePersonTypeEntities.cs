using Rocket.DAL.Common.DbModels.Parser;
using System.Collections.Generic;

namespace Rocket.BL.Tests.ReleaseList.FakeData
{
    public class FakePersonTypeEntities
    {
        public FakePersonTypeEntities()
        {
            PersonTypeEntities = new List<PersonTypeEntity>()
            {
                new PersonTypeEntity()
                {
                    Code = 1,
                    Name = "Актер",
                    Persons = new List<PersonEntity>()
                },
                new PersonTypeEntity()
                {
                    Code = 2,
                    Name = "Режиссер",
                    Persons = new List<PersonEntity>()
                },
                new PersonTypeEntity()
                {
                    Code = 3,
                    Name = "Продюсер",
                    Persons = new List<PersonEntity>()
                },
                new PersonTypeEntity()
                {
                    Code = 4,
                    Name = "Сценарист",
                    Persons = new List<PersonEntity>()
                }
            };
        }

        public List<PersonTypeEntity> PersonTypeEntities { get; }
    }
}
