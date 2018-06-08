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
		private Player currentPlayer = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void characterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewCharacterForm newcharform = new NewCharacterForm();
			if (newcharform.ShowDialog() == DialogResult.OK)
			{
				currentPlayer = newcharform.GetNewPlayer();
				lblPlayerName.Text = currentPlayer.Name;
				lblPlayerClass.Text = currentPlayer.Class.Name;
				lblPlayerClass.Location = new Point(lblPlayerClass.Location.X + lblPlayerClass.Width,
													lblPlayerClass.Location.Y);

				lblMorale.Text = currentPlayer.Stats.Morale.ToString();
				lblPower.Text = currentPlayer.Stats.Power.ToString();
				lblPlayerArmor.Text = currentPlayer.Stats.Armor.ToString();
				lblPlayerMight.Text = currentPlayer.Stats.Might.ToString();
				lblPlayerVitality.Text = currentPlayer.Stats.Vitality.ToString();
				lblPlayerAgility.Text = currentPlayer.Stats.Agility.ToString();
				lblPlayerWill.Text = currentPlayer.Stats.Will.ToString();
				lblPlayerFate.Text = currentPlayer.Stats.Fate.ToString();
			}
		}
	}
}
