using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(txtEhliyet.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet başvurusunda bulunabilirsiniz.");
            }
        }
    }
}
