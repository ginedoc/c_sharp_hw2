using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class ini : Form
    {
        int[] occup = new int[9];
        public ini()
        {
            InitializeComponent();
        }

        private void ini_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();

            f1.pass_occup(occup);
            f2.pass_occup(occup);

            this.Close();
        }

        public void get_occup(int[] occ)
        {
            occup = occ;
        }
    }
}
