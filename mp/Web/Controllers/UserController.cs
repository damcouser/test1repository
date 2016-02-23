using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Script.Serialization;
using System.Web.Security;
using Web.Models;

namespace Web.Controllers
{
	[RoutePrefix("api/user")]
	public class UserController : ApiController
	{
#if DEBUG
		[HttpGet, HttpPost, AllowAnonymous]
#else
		[HttpPost, AllowAnonymous]
#endif
		[Route("login"), ResponseType(typeof(void))]
		public IHttpActionResult Login(LoginModel loginModel)
		{
			var userId = Logic.Data.User.Login(loginModel.Username, loginModel.Password);

			if (userId > 0)
			{
				CreateAuthenticationTicket(userId);
				return Ok();
			}
			return BadRequest();
		}

		[HttpGet, AllowAnonymous]
		[Route("logout"), ResponseType(typeof(void))]
		public IHttpActionResult Logout(LoginModel loginModel)
		{
			HttpContext.Current.Response.Cookies.Clear();
			return Ok();
		}

		public void CreateAuthenticationTicket(Int32 userId)
		{
			var authTicket = new FormsAuthenticationTicket(1, userId.ToString(), DateTime.Now, DateTime.Now.AddHours(8), false, new JavaScriptSerializer().Serialize(userId));
			string encTicket = FormsAuthentication.Encrypt(authTicket);
			HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
		}
	}
}
