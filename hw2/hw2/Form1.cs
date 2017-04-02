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
    public partial class Form1 : Form
    {
        Form2 secondForm = new Form2();
        DialogResult response;
        PictureBox[] table = new PictureBox[9];
        int[] occup = new int[9];
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table[0] = A4_1; table[1] = A4_2;
            table[2] = A5_1; table[3] = A5_2; table[4] = A5_3; table[5] = A5_4;
            table[6] = B6_1; table[7] = B6_2; table[8] = B6_3;

            button2.Enabled = button1.Enabled = false;

            for (int i = 0; i < 9; i++)
            {
                switch (occup[i])
                {
                    case 0:
                        table[i].BackColor = Color.Green;
                        break;
                    case 1:
                        table[i].BackColor = Color.Yellow;
                        break;
                    case 2:
                        table[i].BackColor = Color.Red;
                        break;
                    default:
                        table[i].BackColor = Color.Green;
                        break;
                }
            }
                secondForm.pass_occup(occup);
            secondForm.Show();
        }
        public void pass_occup(int[] occ)
        {
            occup = occ;
        }

        private void A4_1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;
           
            for (int i = 0; i < 9; i++)
            {
                if (i == 0)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void A4_2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 1)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void A5_1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 2)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void A5_2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 3)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void A5_3_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 4)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            


        }

        private void A5_4_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void B6_1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 6)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void B6_2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 7)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void B6_3_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                if (i == 8)
                    table[i].BorderStyle = BorderStyle.Fixed3D;
                else table[i].BorderStyle = BorderStyle.None;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (table[i].BorderStyle == BorderStyle.Fixed3D)
                {
                    if (occup[i] == 1){
                        response = MessageBox.Show("餐點送出", "送餐提醒", MessageBoxButtons.OKCancel );
                        if (response == System.Windows.Forms.DialogResult.OK)
                        {
                                occup[i] = 2;
                                table[i].BackColor = Color.Red;
                        }
                    }
                    else if(occup[i] == 0) 
                            response = MessageBox.Show("本桌尚未有客人", "桌面為空", MessageBoxButtons.OK);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (table[i].BorderStyle == BorderStyle.Fixed3D && occup[i] == 2)
                {
                    occup[i] = 0;
                    table[i].BackColor = Color.Green;
                    break;
                }
            }
        }

    }
}
