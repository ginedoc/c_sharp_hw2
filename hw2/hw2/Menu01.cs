using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;


namespace hw2
{
    public partial class Menu01 : Form
    {
        MoneyMachine money_machine = new MoneyMachine();
        CheckBox[] dishlist = new CheckBox[6];
        Label[] dishmenu = new Label[6];
        int money;
        int peoNum;
        int[] occup = new int[9];
        public Menu01()
        {
            InitializeComponent();
        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            confirm.Enabled = false;

            dishlist[0] = checkBox1; dishlist[1] = checkBox2;
            dishlist[2] = checkBox3; dishlist[3] = checkBox4;
            dishlist[4] = checkBox5; dishlist[5] = checkBox7;

            dishmenu[0] = dish1; dishmenu[1] = dish2;
            dishmenu[2] = dish3; dishmenu[3] = dish4;
            dishmenu[4] = dish5; dishmenu[5] = dish6;

            dishPic.SizeMode = PictureBoxSizeMode.StretchImage;

            money = 0;
            total.Text = "總共:" + "   " + "元";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true){
                money += 40;
                confirm.Enabled = true;
            }
                
            else
                money -= 40;

            total.Text = "總共:" + money + "元";
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true){
                money += 50;
                confirm.Enabled = true;
            }
                
            else
                money -= 50;
            total.Text = "總共:" + money + "元";
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true){
                money += 60;
                confirm.Enabled = true;
            }
            else
                money -= 60;
            total.Text = "總共:" + money + "元";
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true){
                money += 60;
                confirm.Enabled = true;
            }
            else
                money -= 60;
            total.Text = "總共:" + money + "元";
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true){
                money += 70;
                confirm.Enabled = true;
            }                
            else
                money -= 70;
            total.Text = "總共:" + money + "元";
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true){
                money += 90;
                confirm.Enabled = true;
            }                
            else
                money -= 90;
            total.Text = "總共:" + money + "元";
        }
        private void dish1_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\陽春麵.jpg", true);
        }
        private void dish2_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\榨菜肉絲麵.jpg", true);
        }
        private void dish3_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\排骨酥麵.jpg", true);
        }
        private void dish4_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\麻醬麵.jpg", true);
        }
        private void dish5_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\餛飩麵.jpg", true);
        }
        private void dish6_MouseMove(object sender, MouseEventArgs e)
        {
            dishPic.Image = Image.FromFile("..\\Pic\\牛肉麵.jpg", true);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                dishlist[i].CheckState = 0;
            }
            confirm.Enabled = false;
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            this.Close();
            money_machine.get_total_money(money);
            money_machine.pass_peoNum(peoNum);
            money_machine.pass_occup(occup);
            money_machine.Show();
        }

        public void pass_peoNum(int num)
        {
            peoNum = num;
        }
        public void pass_occup(int[] occ)
        {
            occup = occ;
        }
    }
}
