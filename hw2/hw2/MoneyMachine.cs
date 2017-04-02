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
    public partial class MoneyMachine : Form
    {
        public MoneyMachine()
        {
            InitializeComponent();
        }
        public void get_total_money(int money){
            total_money = money;
        }
        private void MoneyMachine_Load(object sender, EventArgs e)
        {
            button8.Enabled = false;

            Return.BackgroundImage = Image.FromFile(@"..\Pic\return.bmp");
            Return.BackgroundImageLayout = ImageLayout.Stretch;

            label1.Text = "總共" + total_money + "元";
            paid.Text = "支付:" + paid_money + "元";
            remain.Text = "找零" + remain_money + "元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paid_money += 1000;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            paid_money += 500;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paid_money += 100;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paid_money += 50;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paid_money += 10;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paid_money += 5;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paid_money += 1;
            paid.Text = "支付:" + paid_money + "元";
            get_charge();
        }

        private void get_charge()
        {
            remain_money = paid_money - total_money;
            if (remain_money >= 0)
            {
                remain.Text = "找零" + remain_money + "元";
                button8.Enabled = true;
            }
                
        }

        int total_money;
        int paid_money;
        int remain_money;
        int peoNum;
        int[] occup = new int[9];

        Button[] money = new Button[7];

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Table_Custom table = new Table_Custom();
            table.pass_peoNum(peoNum);
            table.pass_occup(occup);
            table.Show();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu01 menu = new Menu01();
            menu.Show();
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
