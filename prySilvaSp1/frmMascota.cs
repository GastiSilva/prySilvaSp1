using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaSp1
{
    public partial class frmMascota : Form
    {
        public frmMascota()
        {
            InitializeComponent();
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            PictureBox mascota1 = new PictureBox();
            PictureBox mascota2 = new PictureBox();
            PictureBox mascota3 = new PictureBox();

            mascota1.Image = Properties.Resources.perro2;
            mascota1.SizeMode = PictureBoxSizeMode.StretchImage;
            mascota1.Location = new Point(15, 15);

            mascota2.Image = Properties.Resources.pato2;
            mascota2.SizeMode = PictureBoxSizeMode.StretchImage;
            mascota2.Location = new Point(130, 15);

            mascota3.Image = Properties.Resources.cat_hat2;
            mascota3.SizeMode = PictureBoxSizeMode.StretchImage;
            mascota3.Location = new Point(245, 15);

            Controls.Add(mascota1);
            Controls.Add(mascota2);
            Controls.Add(mascota3);
        }
    }
}
