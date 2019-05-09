using System;
using System.Windows.Forms;

namespace Farmgame
{
    public partial class frmain : Form
    {
        Barn b;
        Wallet w;
        public frmain()
        {
            InitializeComponent();
            b = new Barn();
            w = new Wallet(10000);
            Checkmoney();

        }

        private void frmain_Load(object sender, EventArgs e)
        {

        }

        private void btntest1_Click(object sender, EventArgs e)
        {
            Cow k1 = new Cow();
            lbltest1.Text = k1.WriteAnimal();
            Chicken c1 = new Chicken();
            lbltest1.Text += c1.WriteAnimal();
        }

        private void Btnbuycow_Click(object sender, EventArgs e)
        {
            Cow k = new Cow();
            string mess = b.Newanimal(k);
            lbltest2.Text = mess;
        }

        private void Btnbuychicken_Click(object sender, EventArgs e)
        {
            Chicken k = new Chicken();
            if (w.Money >= k.Prize)
            {
                string mess = b.Newanimal(k);
                lbltest2.Text = mess;
                w.Money = w.Money - k.Prize;
            }
            else
                Nomoney();
            
        }
        private void Checkmoney()
        {
            lblmoney2.Text = w.Money + "kr";
        }
        private void Nomoney()
        {
            lblmoney1.Text = "Sorry its to expensive";
        }
    }
}
