using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü_örnek_2_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
             for( int i = 25; i <= 75; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
