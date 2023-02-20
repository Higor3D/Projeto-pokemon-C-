using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digimon._3
{
    public partial class Pokemons : Form
    {
        public Pokemons() => InitializeComponent();

        private void btnMankey_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.mankey1;
        }

        private void btnAbra_CheckedChanged_1(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.abra1;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            lblname.Text = "Higor Gomes";
        }

        private void btnGrowlithe_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.growlithe1;

        }

        private void btnZubat_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = (Properties.Resources.zubat1);
        }

        private void btnPsyduck_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.PSYDUCK1;

        }

        private void btnCartepie_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.cartepie1;
        }

        private void btnRatata_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.ratata1;
        }

        private void btnWeedle_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.resources.weedle1;
        }

        private void btnOddish_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image = Properties.Resources.odissh1;
        }

        private void btnPikachu_CheckedChanged(object sender, EventArgs e)
        {
            foto.Image= Properties.Resources.pikachu1;
        }

        private void foto_Click(object sender, EventArgs e)
        {

        }

        private void Pokemons_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
