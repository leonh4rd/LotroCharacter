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
			_type = LotroClassType.HUNTER;
		}
		public override String Name
		{
			get
			{
				return _name;
			}
		}

		public override LotroClassType Type
		{
			get
			{
				return _type;
			}
		}
	}
}
