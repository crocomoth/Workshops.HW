using System;
using System.Collections.Generic;
using Rocket.BL.Common.DtoModels.ReleaseList;

namespace Rocket.BL.Common.Services.ReleaseList
{
    public interface IMusicGenreService : IDisposable
    {
        IEnumerable<GenreDto> GetMusicGenres();
    }
}
