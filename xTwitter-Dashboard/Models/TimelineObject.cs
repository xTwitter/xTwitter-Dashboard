using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xTwitter_Dashboard.Models
{
	class TimelineObject
	{
		public Image Profile
		{
			get;

			set;
		}

		public String Name
		{
			get;

			set;
		}

		public String ScreenName
		{
			get;

			set;
		}

		public String Text
		{
			get;

			set;
		}

		public ulong StatusID
		{
			get;

			set;
		}

		public int RTCount
		{
			get;

			set;
		}

		public int FavoriteCount
		{
			get;

			set;
		}
	}
}
