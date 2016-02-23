using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Web.Models;

namespace Web.Controllers
{
	[RoutePrefix("api")]
	public class MessageController : ApiController
	{
		/// <summary>
		/// Return a single message for detailed view
		/// </summary>
		[HttpGet]
		[Route("message"), ResponseType(typeof(MessageModel))]
		public IHttpActionResult Get([FromUri]Int32 id)
		{
            var message = Logic.Data.Messages.GetMessageById(id);//.SingleOrDefault(m => m.MessageId.Equals(id));

            if (message == null)
                return BadRequest();

            return Ok<MessageModel>(AutoMapper.Mapper.Map<MessageModel>(message));
        }
    }
}
