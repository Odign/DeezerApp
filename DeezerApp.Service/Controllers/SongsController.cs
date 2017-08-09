using DeezerApp.Service.Domain;
using DeezerApp.Service.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DeezerApp.Service.Controllers
{
    public class SongsController : ApiController
    {
        private IService deezerService ;
        private const int MAX_SONG_QUANTITY = 150;

        public SongsController() {
            string mashapKey = ConfigurationManager.AppSettings["MashapeKey"];
            deezerService = new DeezerService(mashapKey);
        }

        public SongsController(IService serviceImpl)
        {
            deezerService = serviceImpl;
        }

        [HttpGet]
        public IHttpActionResult GetSongsByArtist([FromUri]string artistName)
        {
            try
            {
                ServiceResponse serviceResponse = deezerService.GetSongs(artistName);
                return Ok(serviceResponse.GetQuantityOfSongs(MAX_SONG_QUANTITY));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}
