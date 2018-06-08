using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	class Elf : LotroRace
	{
		public Elf()
		{
			bonus = new Dictionary<EStat, double>();
			baseStat = new Dictionary<EStat, double>();

			baseStat.Add(EStat.Morale, 86);
			baseStat.Add(EStat.Power, 50);
			baseStat.Add(EStat.Armor, 5);
			baseStat.Add(EStat.Might, 8);
			baseStat.Add(EStat.Agility, 29);
			baseStat.Add(EStat.Vitality, 10);
			baseStat.Add(EStat.Will, 14);
			baseStat.Add(EStat.Fate, 4);

			bonus.Add(EStat.Agility, 15);
			bonus.Add(EStat.Fate, -7);
			bonus.Add(EStat.Morale, -20);
			bonus.Add(EStat.NCMR, -60);
			bonus.Add(EStat.DiseaseResistance, 0.01);
			bonus.Add(EStat.PoisonResistance, 0.01);

			_name = "Elf";
			_type = LotroRaceType.ELF;
		}

		public override Dictionary<EStat, double> GetBonus()
		{
			return bonus;
		}

		public override Dictionary<EStat, double> GetBaseStat()
		{
			return baseStat;
		}
	}
}
