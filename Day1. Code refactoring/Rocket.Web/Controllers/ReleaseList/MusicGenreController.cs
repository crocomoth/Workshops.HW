using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rocket.BL.Common.Services.ReleaseList;

namespace Rocket.Web.Controllers.ReleaseList
{
    public class MusicGenreController : ApiController
    {
        private readonly IMusicGenreService _musicGenreService;

        public MusicGenreController(IMusicGenreService genreService)
        {
            _musicGenreService = genreService;
        }

        [HttpGet]
        [Route("series/all")]
        public IHttpActionResult GetAllTvSeriesGenres()
        {
            var genres = _musicGenreService.GetMusicGenres();
            return genres == null ? (IHttpActionResult)NotFound() : Ok(genres);
        }
    }
}
