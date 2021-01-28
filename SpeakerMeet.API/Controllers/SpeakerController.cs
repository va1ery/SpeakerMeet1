using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace SpeakerMeet.API.Controllers
{
	[Route("api/[controller]")]
	public class SpeakerController : Controller
	{
/* public SpeakerController(ISpeakerService speakerService)
{
}
 */
 public interface ISpeakerService
{
      IEnumerable<Speaker> Search(string searchString);
}
        // GET api/values
//        [HttpGet]
        private readonly ISpeakerService _speakerService;
        public SpeakerController(ISpeakerService speakerService)
        {
        _speakerService = speakerService;
        }
        [Route("search")]
        public IActionResult Search(string searchString)
        {
            var hardCodedSpeakers = new List<Speaker>
            {
                new Speaker {Name = "Josh"},
                new Speaker {Name = "Joshua"},
                new Speaker {Name = "Joseph"},
                new Speaker {Name = "Bill"},
            };

            _speakerService.Search("foo");
            var speakers = hardCodedSpeakers
                .Where(x => 
                x.Name.StartsWith(searchString, 
                StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(speakers);
        }


	}
	    public class Speaker
			{
				public string Name { get; set; }
			}
}