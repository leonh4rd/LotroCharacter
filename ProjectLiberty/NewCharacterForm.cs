using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLiberty
{
	public partial class NewCharacterForm : Form
	{
		private String _name;
		private String _race;
		private String _class;

		public NewCharacterForm()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			_name = txtName.Text;
			_race = cbxRace.SelectedItem.ToString();
			_class = cbxClass.SelectedItem.ToString();
			DialogResult = DialogResult.OK;
		}

		public Player GetNewPlayer()
		{
			Player player = new Player(_name);
			player.Race = CreateRace(_race);

			if (_class == "Hunter")
			{
				player.Class = new Hunter();
			}

			player.UpdateStats(player.Race.GetBaseStat());
			return player;
		}

		private LotroRace CreateRace(String selected)
		{
			if (selected == "Man")
			{
				return new Elf();
			}
			else if (selected == "Elf")
			{
				return new Elf();
			}
			else if (selected == "Hobbit")
			{
				return new Elf();
			}
			else if (selected == "Dwarf")
			{
				return new Elf();
			}
			else if (selected == "Beorning")
			{
				return new Elf();
			}
			else if (selected == "HigH Elf")
			{
				return new Elf();
			}
			return null;
		}
	}
}
