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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Player player = new Player("Illuviel");
			player.Class = new Hunter();
			player.Race = new Elf();
			player.UpdateStats(player.Race.GetBaseStat());
			lblPlayerName.Text = player.Name;
			lblPlayerClass.Text = player.Class.Name;
			lblPlayerClass.Location = new Point(lblPlayerClass.Location.X + lblPlayerClass.Width,
												lblPlayerClass.Location.Y);
			lblMorale.Text = player.Stats.Morale.ToString();
			lblPower.Text = player.Stats.Power.ToString();
			lblPlayerArmor.Text = player.Stats.Armor.ToString();
			lblPlayerMight.Text = player.Stats.Might.ToString();
			lblPlayerVitality.Text = player.Stats.Vitality.ToString();
			lblPlayerAgility.Text = player.Stats.Agility.ToString();
			lblPlayerWill.Text = player.Stats.Will.ToString();
			lblPlayerFate.Text = player.Stats.Fate.ToString();
		}
	}
}
