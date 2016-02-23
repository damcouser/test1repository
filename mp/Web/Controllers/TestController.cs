using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Web.Controllers
{
	[RoutePrefix("api")]
	public class TestController : ApiController
	{
		[HttpGet, HttpPost, AllowAnonymous]
		[Route("test"), ResponseType(typeof(String))]
		public IHttpActionResult Get()
		{
			return Ok(new { Text = "Space: the final frontier. These are the voyages of the starship Enterprise. Its continuing mission: to explore strange new worlds, to seek out new life and new civilizations, to boldly go where no one has gone before." });
		}

		[AllowAnonymous]
		[HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
		[ApiExplorerSettings(IgnoreApi = true)]
		public IHttpActionResult Handle404()
		{
			return Redirect(new Uri("/test", UriKind.Relative));
		}
	}
}
