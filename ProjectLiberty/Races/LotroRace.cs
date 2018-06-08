using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	abstract class LotroRace
	{
		protected String _name;
		protected Dictionary<EStat, double> bonus;
		protected Dictionary<EStat, double> baseStat;
		public abstract Dictionary<EStat, double> GetBonus();
		public abstract Dictionary<EStat, double> GetBaseStat();
	}
}
