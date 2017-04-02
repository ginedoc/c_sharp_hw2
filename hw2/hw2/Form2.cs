using System;
using System.Drawing;
using System.Windows.Forms;



//  客戶端
namespace hw2
{
    public partial class Form2 : Form
    {
        Menu01 OrderMenu = new Menu01();
        // 初始歡迎畫面
        Label greet0 = new Label();
        Label greet1 = new Label();
        int numPeo;
        int[] occup = new int[9];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            greeting_menu();
        }
        private void greeting_menu()
        {
            // 初始       
            greet0.Enabled = true;
            greet0.Location = setPosition(30, 10);
            greet0.Text = "歡迎光臨";
            this.Controls.Add(greet0);

            greet1.Location = setPosition(30, 20);
            greet1.Text = "請問多少人用餐?";
            this.Controls.Add(greet1);

            numP.Location = setPosition(10, 50);
            confirm.Location = setPosition(60,50);

        }

        private Point setPosition(int percent_X, int percent_Y)
        {
            float form1_W;
            float form1_H;
            Point P = new Point();

            form1_W = this.Width;
            form1_H = this.Height;
            P.X = (int)Math.Ceiling(percent_X * form1_W / 100);
            P.Y = (int)Math.Ceiling(percent_Y * form1_H / 100);
            return P;
        }
        private void Form2_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

            greet0.Location = setPosition(30, 10);
            greet1.Location = setPosition(30, 20);

            numP.Location = setPosition(10,50);
            confirm.Location = setPosition(60, 50);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DialogResult err;
            int i;
            if (string.IsNullOrWhiteSpace( numP.Text ) || !Int32.TryParse(numP.Text, out i))
                err = MessageBox.Show("需要輸入人數(數字)", "輸入錯誤", MessageBoxButtons.OK);
            else
            {
                numPeo = Convert.ToInt32(numP.Text);
                OrderMenu.pass_peoNum(numPeo);
                OrderMenu.pass_occup(occup);
                OrderMenu.Show();
                this.Close();
            }            
        }

        public void pass_occup(int[] occ)
        {
            occup = occ;
        }
    }


}
      