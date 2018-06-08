using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLiberty
{
	public enum EStat { Morale, Power, Armor, Wrath, Might, Vitality, Agility, Will, Fate, NCMR, ICMR, NCPR, ICPR,
	            PhysicalMastery, TacticalMastery, PhysicalMitigation, TacticalMitigation, DiseaseResistance,
				PoisonResistance, FearResistance, WoundResistance, Block, Evade, Parry};

	public class LotroStat
	{
		private double _morale;
		private double _power;
		private double _armor;
		private double _wrath;
		private double _might;
		private double _vitality;
		private double _agility;
		private double _fate;
		private double _will;
		private double _ncmr;
		private double _icmr;
		private double _ncpr;
		private double _icpr;
		private double _physmastery;
		private double _tactmastery;
		private double _physmit;
		private double _tactmit;
		private double _diseaseres;
		private double _poisonres;
		private double _fearres;
		private double _woundres;
		private double _block;
		private double _evade;
		private double _parry;

		public double Morale
		{
			get
			{
				return _morale;
			}
			set
			{
				if (value > 0.0f)
				{
					_morale = value;
				}
			}
		}

		public double Power
		{
			get
			{
				return _power;
			}
			set
			{
				if (value > 0.0f)
				{
					_power = value;
				}
			}
		}

		public double Armor
		{
			get
			{
				return _armor;
			}
			set
			{
				if (value > 0.0f)
				{
					_armor = value;
				}
			}
		}

		public double Wrath
		{
			get
			{
				return _wrath;
			}
			set
			{
				if (value > 0.0f)
				{
					_wrath = value;
				}
			}
		}

		public double Might
		{
			get
			{
				return _might;
			}
			set
			{
				if (value > 0.0f)
				{
					_might = value;
				}
			}
		}

		public double Vitality
		{
			get
			{
				return _vitality;
			}
			set
			{
				if (value > 0.0f)
				{
					_vitality = value;
				}
			}
		}

		public double Agility
		{
			get
			{
				return _agility;
			}
			set
			{
				if (value > 0.0f)
				{
					_agility = value;
				}
			}
		}

		public double Fate
		{
			get
			{
				return _fate;
			}
			set
			{
				if (value > 0.0f)
				{
					_fate = value;
				}
			}
		}

		public double Will
		{
			get
			{
				return _will;
			}
			set
			{
				if (value > 0.0f)
				{
					_will = value;
				}
			}
		}

		public double NCMR
		{
			get
			{
				return _ncmr;
			}
			set
			{
				if (value > 0.0f)
				{
					_ncmr = value;
				}
			}
		}

		public double ICMR
		{
			get
			{
				return _icmr;
			}
			set
			{
				if (value > 0.0f)
				{
					_icmr = value;
				}
			}
		}

		public double NCPR
		{
			get
			{
				return _ncpr;
			}
			set
			{
				if (value > 0.0f)
				{
					_ncpr = value;
				}
			}
		}

		public double ICPR
		{
			get
			{
				return _icpr;
			}
			set
			{
				if (value > 0.0f)
				{
					_icpr = value;
				}
			}
		}

		public double PhysicalMastery
		{
			get
			{
				return _physmastery;
			}
			set
			{
				if (value > 0.0f)
				{
					_physmastery = value;
				}
			}
		}

		public double TacticalMastery
		{
			get
			{
				return _tactmastery;
			}
			set
			{
				if (value > 0.0f)
				{
					_tactmastery = value;
				}
			}
		}

		public double PhysicalMitigation
		{
			get
			{
				return _physmit;
			}
			set
			{
				if (value > 0.0f)
				{
					_physmit = value;
				}
			}
		}

		public double TacticalMitigation
		{
			get
			{
				return _tactmit;
			}
			set
			{
				if (value > 0.0f)
				{
					_tactmit = value;
				}
			}
		}

		public double DiseaseResistance
		{
			get
			{
				return _diseaseres;
			}
			set
			{
				if (value > 0.0f)
				{
					_diseaseres = value;
				}
			}
		}

		public double PoisonResistance
		{
			get
			{
				return _poisonres;
			}
			set
			{
				if (value > 0.0f)
				{
					_poisonres = value;
				}
			}
		}

		public double FearResistance
		{
			get
			{
				return _fearres;
			}
			set
			{
				if (value > 0.0f)
				{
					_fearres = value;
				}
			}
		}

		public double WoundResistance
		{
			get
			{
				return _woundres;
			}
			set
			{
				if (value > 0.0f)
				{
					_woundres = value;
				}
			}
		}

		public double Block
		{
			get
			{
				return _block;
			}
			set
			{
				if (value > 0.0f)
				{
					_block = value;
				}
			}
		}

		public double Evade
		{
			get
			{
				return _evade;
			}
			set
			{
				if (value > 0.0f)
				{
					_evade = value;
				}
			}
		}

		public double Parry
		{
			get
			{
				return _parry;
			}
			set
			{
				if (value > 0.0f)
				{
					_parry = value;
				}
			}
		}
	}
}
