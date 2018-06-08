using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	class Hunter : LotroClass
	{
		public Hunter()
		{
			_name = "Hunter";
		}
		public override String Name
		{
			get
			{
				return _name;
			}
		}
	}
}
