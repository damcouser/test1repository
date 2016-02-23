using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;

namespace Web.App_Start
{
	public class JsonContentNegotiator : IContentNegotiator
	{
		private readonly JsonMediaTypeFormatter jsonFormatter;

		public JsonContentNegotiator(JsonMediaTypeFormatter formatter)
		{
			jsonFormatter = formatter;
		}

		public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
		{
			var result = new ContentNegotiationResult(jsonFormatter, new MediaTypeHeaderValue("application/json"));
			return result;
		}
	}
}
