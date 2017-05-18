using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace xTwitter_Dashboard.Repositories
{
	public class AccountReository
	{
		public PinAuthorizer pinAuthorizer
		{
			get;

			set;
		}

		public TwitterContext twitterContext
		{
			get;

			set;
		}

		public User user
		{
			get;

			set;
		}
	}
}
