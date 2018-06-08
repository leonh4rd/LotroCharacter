using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	class Player
	{
		private LotroStat _stats;
		private String _name;
		private LotroClass _class;
		private LotroRace _race;

		public Player()
		{
			_stats = new LotroStat();
			_stats.Might = 0;
			_stats.Vitality = 0;
			_stats.Agility = 0;
			_stats.Will = 0;
			_stats.Fate = 0;
		}

		public Player(String pname) : this()
		{
			_name = pname;
			_class = null;
			_race = null;
		}

		public String Name
		{
			get
			{
				return _name;
			}
		}

		public LotroClass Class
		{
			get
			{
				return _class;
			}
			set
			{
				if (_class == null)
				{
					_class = value;
				}
			}
		}

		public LotroRace Race
		{
			get
			{
				return _race;
			}
			set
			{
				if (_race == null)
				{
					_race = value;
				}
			}
		}

		public LotroStat Stats
		{
			get
			{
				return _stats;
			}
		}

		public void UpdateStats(Dictionary<EStat, double> list)
		{
			int counter = list.Count;
			foreach (KeyValuePair<EStat, double> kvp in list)
			{
				if (kvp.Key == EStat.Morale)
				{
					_stats.Morale += kvp.Value;
				}
				else if (kvp.Key == EStat.Power)
				{
					_stats.Power += kvp.Value;
				}
				else if (kvp.Key == EStat.Armor)
				{
					_stats.Armor += kvp.Value;
				}
				else if (kvp.Key == EStat.Might)
				{
					_stats.Might += kvp.Value;
				}
				else if (kvp.Key == EStat.Vitality)
				{
					_stats.Vitality += kvp.Value;
				}
				else if (kvp.Key == EStat.Agility)
				{
					_stats.Agility += kvp.Value;
				}
				else if (kvp.Key == EStat.Will)
				{
					_stats.Will += kvp.Value;
				}
				else if (kvp.Key == EStat.Fate)
				{
					_stats.Fate += kvp.Value;
				}
			}
		}
	}
}
