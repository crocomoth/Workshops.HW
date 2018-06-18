using System.Web.Http;
using Rocket.BL.Common.Services.ReleaseList;

namespace Rocket.Web.Controllers.ReleaseList
{
    public class TvGenreController : ApiController
    {
        private readonly ITvGenreService _genreService;

        public TvGenreController(ITvGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        [Route("series/all")]
        public IHttpActionResult GetAllTvSeriesGenres()
        {
            var genres = _genreService.GetTvSeriesGenres();
            return genres == null ? (IHttpActionResult)NotFound() : Ok(genres);
        }

    }
}
