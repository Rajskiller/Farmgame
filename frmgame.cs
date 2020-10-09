using System;
using System.Windows.Forms;

namespace Farmgame
{
    public partial class frmgame : Form
    {
        Barn b;
        Wallet w;
        Energy eng;
        int amountofcows = 0;
        int amonutofchickens = 0;
        int amountofsheeps = 0;
        int amountofpigs = 0;

        public frmgame()
        {
            InitializeComponent();

            b = new Barn();
            w = new Wallet(10000);
            Checkmoney();
            eng = new Energy();

        }

        private void frmain_Load(object sender, EventArgs e)
        {

        }

        private void Btnmainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainmenu f2 = new frmMainmenu();
            f2.ShowDialog();
            this.Close();
        }

        private void btnmilk_Click(object sender, EventArgs e)
        {
            Cow k1 = new Cow();
            for (int i = 0; i< 50; i++)
            {
                if(eng.Engval > k1.Energyexpens)
                {
                    eng.Engval -= k1.Energyexpens;

                }
            }
            lblmilkcow.Text = k1.WriteAnimal();
           
        }
        private void btncolchi_Click(object sender, EventArgs e)
        {
            Chicken ch1 = new Chicken();
            for (int i = 0; i < 50; i++)
            {
                if (eng.Engval > ch1.Energyexpens)
                {
                    eng.Engval -= ch1.Energyexpens;
                }
                else
                {
                    noenergy();
                }
            }
            lblcollecteggs.Text += ch1.WriteAnimal();
        }
        private void btncolwol_Click(object sender, EventArgs e)
        {
            Sheep s1 = new Sheep();
            for(int i = 0; i< 50; i++)
            {
                if (eng.Engval > s1.Energyexpens)
                {
                    eng.Engval -= s1.Energyexpens;
                    w.Money += s1.Income();
                }
                else
                {
                    noenergy();
                }
            }
        }

        private void btnkilpig_Click(object sender, EventArgs e)
        {
            Pig p1 = new Pig();
            for (int i = 0; i < 50; i++)
            {
                if (eng.Engval > p1.Energyexpens)
                {
                    eng.Engval -= p1.Energyexpens;
                }
                else
                {
                    noenergy();
                }
            }

        }

        private void Btnbuycow_Click(object sender, EventArgs e)
        {
            Cow c = new Cow();
            if (b.Full == false && w.Money >= c.Prize)
            {
                string mess = b.Newanimal(c);
                lblbuycow.Text = mess;
                w.Money -= c.Prize;
                Checkmoney();
                lblspace.Text = b.Bcheckanimal();
                
            }
            else if(b.Full==true)
            {
                lblbuycow.Text = "Sorry the barn is full";
            }
            else
                Nomoney();
        }

        private void Btnbuychicken_Click(object sender, EventArgs e)
        {
            Chicken ch = new Chicken();
            if (b.Full == false && w.Money >= ch.Prize)
            {
                string mess = b.Newanimal(ch);
                lblbuychicken.Text = mess;
                w.Money -= ch.Prize;
                Checkmoney();
                lblspace.Text = b.Bcheckanimal();
            }
            else if (b.Full == true)
            {
                lblbuychicken.Text = "Sorry the barn is full";
            }
            else
                Nomoney();
            
        }
        private void Btnbuysheep_Click(object sender, EventArgs e)
        {
            Sheep s = new Sheep();
            if (b.Full ==false && w.Money >= s.Prize)
            {
                string mess = b.Newanimal(s);
                lblbuysheep.Text = mess;
                w.Money -= s.Prize;
                Checkmoney();
                lblspace.Text = b.Bcheckanimal();
            }
            else if (b.Full == true)
            {
                lblbuysheep.Text = "Sorry the barn is full";
            }
            else
                Nomoney();
                
        }
        private void Btnbuypig_Click(object sender, EventArgs e)
        {
            Pig p = new Pig();
            if (b.Full == false && w.Money >= p.Prize)
            {
                string mess = b.Newanimal(p);
                lblbuypig.Text = mess;
                w.Money -= p.Prize;
                Checkmoney();
                lblspace.Text = b.Bcheckanimal();
            }
            else if (b.Full == true)
            {
                lblbuypig.Text = "Sorry the barn is full";
            }
            else
                Nomoney();
                
        }
        private void btnsellcow_Click(object sender, EventArgs e)
        {

        }

        private void btnsellchicken_Click(object sender, EventArgs e)
        {

        }

        private void btnsellsheep_Click(object sender, EventArgs e)
        {

        }

        private void btnsellpig_Click(object sender, EventArgs e)
        {

        }
        private void Checkmoney()
        {
            lblmoney2.Text = w.Money + "kr";
        }
        private void Nomoney()
        {
            lblmoney2.Text = "0 kr";
        }
        private void Checkenergy()
        {
            lblamountofenergy.Text = eng.Engval + "";
        }
        private void noenergy()
        {
            lblamountofenergy.Text = "Sorry you dont have enough energy ";
        }
        
        private void lblamountofenergy_Click(object sender, EventArgs e)
        {

        }

        private void lblspace_Click(object sender, EventArgs e)
        {

        }

       
    }
}
