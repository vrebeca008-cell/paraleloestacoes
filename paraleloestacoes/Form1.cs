using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paraleloestacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rad_primeiro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_primeiro.Image = Properties.Resources.fasfsafasfasfsa;
			// Busca a imagem do resources
			Txt_primeiro.Text = "palmeiras sem mundial"; // Muda o texto do TextBox
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Pic_primeiro_Click(object sender, EventArgs e)
        
	

		{
			
        }

        private void Txt_primeiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
