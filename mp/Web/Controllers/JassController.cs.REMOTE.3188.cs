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
    public class JassController : ApiController
    {
        [HttpGet]
        [Route("jass"), ResponseType(typeof(IEnumerable<MessageModel>))]
        public IHttpActionResult Get([FromUri]ViewStyle style)
        {
            var messages = Logic.Data.Messages.Get((this.User as Principal).UserId);
            return Ok<IEnumerable<MessageModel>>(AutoMapper.Mapper.Map<IEnumerable<MessageModel>>(Sort(messages, style)));
        }
        private IEnumerable<Logic.Model.Message> Sort(List<Logic.Model.Message> list, ViewStyle style)
        {
            switch (style)
            {
                              
                case ViewStyle.Date:
                default:
                    return list.OrderBy(m => m.CreatedDate);
            }
        }

        private int get()
        {
            return 0;
        }
    }
}
