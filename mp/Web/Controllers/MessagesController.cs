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
	public class MessagesController : ApiController
	{
		[HttpGet]
		[Route("messages"), ResponseType(typeof(IEnumerable<MessageModel>))]
		public IHttpActionResult Get([FromUri]ViewStyle style)
		{
			var messages = Logic.Data.Messages.Get((this.User as Principal).UserId);
			return Ok<IEnumerable<MessageModel>>(AutoMapper.Mapper.Map<IEnumerable<MessageModel>>(Sort(messages, style)));
		}

		private IEnumerable<Logic.Model.Message> Sort(List<Logic.Model.Message> list, ViewStyle style)
		{
			switch (style)
			{
				case ViewStyle.Author:
					return SortByAuthor(list);
				case ViewStyle.Thread:
					return SortByThread(list);
				case ViewStyle.Date:
				default:
					return list.OrderBy(m => m.CreatedDate);
			}
		}

		/// <summary>
		/// Return messages ordered by Author, then by CreatedDate
		/// </summary>
		private IEnumerable<Logic.Model.Message> SortByAuthor(List<Logic.Model.Message> list)
		{
			var queue = new Queue<Logic.Model.Message>(list);
			var current = queue.Dequeue();
			while (queue.Count > 0)
			{
				if (current.AuthorId.CompareTo(queue.Peek().AuthorId) == 1)
				{
					yield return queue.Dequeue();
				}
				else
				{
					yield return current;
					current = queue.Dequeue();
				}
			}
			yield return current;
		}

		/// <summary>
		/// Return messages ordered by Thread, then by CreatedDate
		/// </summary>
		// TODO: Finish this method so it correctly returns messages by ThreadId and then by CreatedDate without LINQ
		private IEnumerable<Logic.Model.Message> SortByThread(List<Logic.Model.Message> list)
		{
            list.Sort(delegate (Logic.Model.Message message1, Logic.Model.Message message2)
            { return (message1.ThreadId.CompareTo(message2.ThreadId)); });

            return list;
		}
	}
}
