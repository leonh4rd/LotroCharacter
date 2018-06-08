using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	public abstract class LotroClass
	{
		public enum LotroClassType { CHAMPION, HUNTER, GUARDIAN, MINSTREL, BURGLAR, CAPTAIN, LOREMASTER, WARDEN, RUNEKEEPER, BEORNING};
		protected LotroClassType _type;
		protected String _name;
		public abstract LotroClassType Type { get; }
		public abstract String Name{get;}
	}
}
