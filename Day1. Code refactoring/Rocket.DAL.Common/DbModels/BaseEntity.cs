using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.DAL.Common.DbModels
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
}
