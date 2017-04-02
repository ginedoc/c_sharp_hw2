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
    public partial class Table_Custom : Form
    {
        int peoNum;
        int[] occup = new int[9];
        public Table_Custom()
        {
            InitializeComponent();
        }

        PictureBox[] table = new PictureBox[9];
        private void Table_Custom_Load(object sender, EventArgs e)
        {
            table[0] = A4_1; table[1] = A4_2;
            table[2] = A5_1; table[3] = A5_2; table[4] = A5_3; table[5] = A5_4;
            table[6] = B6_1; table[7] = B6_2; table[8] = B6_3;

            for (int i = 0; i < 9; i++)
            {
                if (occup[i] == 1)
                    table[i].BackColor = Color.Red;
            }

             switch (peoNum)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if (occup[i] == 0)
                                {
                                    occup[i] = 1;
                                    table[i].BackColor = Color.Blue;
                                    break;
                                }

                            }

                        }
                        break;
                    case 5:
                    case 6:
                        {
                            for (int i = 7; i < 9; i++)
                            {
                                if (occup[i] == 0)
                                {
                                    occup[i] = 1;
                                    table[i].BackColor = Color.Blue;
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        DialogResult mess = MessageBox.Show("需要併桌，請洽店員", "併桌資訊", MessageBoxButtons.OK);
                        break;
                }
        }
        public void pass_occup(int[] occ)
        {
            occup = occ;
        }
        public void pass_peoNum(int peo)
        {
            peoNum = peo;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.pass_occup(occup);
            form1.Show();
            this.Close();
        }

    }
}
