using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using AutoMapper;
using Newtonsoft.Json.Serialization;
using Web.App_Start;

namespace Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// Web API configuration and services
			var jsonFormatter = new JsonMediaTypeFormatter();
			jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

			// Authorization
			config.Filters.Add(new AuthorizeAttribute());

			// AutoMapper
			Mapper.CreateMap<Logic.Model.Message, Models.MessageModel>();

			// Web API routes
			config.MapHttpAttributeRoutes();
		}
    }
}
