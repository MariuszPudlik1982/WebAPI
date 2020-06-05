using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Picuture.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {
        private static List<PictureDTO> pictures = new List<PictureDTO>();
        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PictureDTO> Get(int id)
        {
            var selectedPicture = pictures.FirstOrDefault(p => p.Id == id);
            return selectedPicture;
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] PictureDTO value)
        {
            if (pictures.Any(p => p.Id == value.Id))
            {
                pictures.Remove(pictures.First(p => p.Id == value.Id));

            }
            pictures.Add(value);

        }

    }
    public class PictureDTO
{
    public int Id { get; set; }
    public string Content { get; set; }
}
}
