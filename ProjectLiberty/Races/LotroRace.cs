using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	public abstract class LotroRace
	{
		public enum LotroRaceType { MAN, ELF, HOBBIT, DWARF, BEORNING, HIGHELF };
		protected LotroRaceType _type;
		protected String _name;
		protected Dictionary<EStat, double> bonus;
		protected Dictionary<EStat, double> baseStat;
		public abstract Dictionary<EStat, double> GetBonus();
		public abstract Dictionary<EStat, double> GetBaseStat();
	}
}
