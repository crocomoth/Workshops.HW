using System.Collections.Generic;
using AutoMapper;
using Rocket.BL.Common.DtoModels.ReleaseList;
using Rocket.BL.Common.Services.ReleaseList;
using Rocket.DAL.Common.UoW;

namespace Rocket.BL.Services.ReleaseList
{
    public class TvGenreService : BaseService, ITvGenreService
    {
        public TvGenreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<GenreDto> GetTvSeriesGenres()
        {
            return Mapper.Map<IEnumerable<GenreDto>>(_unitOfWork.GenreRepository.Get());
        }
    }
}
