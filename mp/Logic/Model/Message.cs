using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.Model
{
	public class Message
	{
		public Int32 MessageId { get; set; }
		public Int32 AuthorId { get; set; }
		public Guid ThreadId { get; set; }
		public String CreatedDate { get; set; }
		public String Text { get; set; }
		public Int32 MessageStatus { get; set; }
        public String UserName { get; set; }
    }
}
