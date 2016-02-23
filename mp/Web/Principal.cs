using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Web
{
	public class Principal : IPrincipal
	{
		public IIdentity Identity { get; private set; }
		public Int32 UserId { get; set; }

		public Principal(Int32 userId)
		{
			this.UserId = userId;
			this.Identity = new System.Security.Principal.GenericIdentity(this.UserId.ToString());
		}

		public bool IsInRole(string role)
		{
			return Identity != null && Identity.IsAuthenticated;
		}
	}
}