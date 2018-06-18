using System.Collections.Generic;
using AutoMapper;
using Rocket.BL.Common.DtoModels.ReleaseList;
using Rocket.BL.Common.Services.ReleaseList;
using Rocket.DAL.Common.UoW;

namespace Rocket.BL.Services.ReleaseList
{
    public class MusicGenreService : BaseService, IMusicGenreService
    {
        public MusicGenreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IEnumerable<GenreDto> GetMusicGenres()
        {
            return Mapper.Map<IEnumerable<GenreDto>>(_unitOfWork.MusicGenreRepository.Get());
        }
    }
}
