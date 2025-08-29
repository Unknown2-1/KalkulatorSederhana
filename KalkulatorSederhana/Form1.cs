namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "1";
            }
            else
            {
                txtdisplay.Text += "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "2";
            }
            else
            {
                txtdisplay.Text += "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "3";
            }
            else
            {
                txtdisplay.Text += "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "4";
            }
            else
            {
                txtdisplay.Text += "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "5";
            }
            else
            {
                txtdisplay.Text += "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "6";
            }
            else
            {
                txtdisplay.Text += "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "7";
            }
            else
            {
                txtdisplay.Text += "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "8";
            }
            else
            {
                txtdisplay.Text += "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "9";
            }
            else
            {
                txtdisplay.Text += "9";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text != "0")
            {
                txtdisplay.Text += "0";
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtdisplay2.Text = " ";
        }

        private void btkali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtdisplay.Text);
            txtdisplay2.Text = "x";
            txtdisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btkoma_Click(object sender, EventArgs e)
        {

        }

        private void btbagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtdisplay.Text);
            txtdisplay2.Text = "/";
            txtdisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btkurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtdisplay.Text);
            txtdisplay2.Text = "-";
            txtdisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtdisplay.Text);
            txtdisplay2.Text = "+";
            txtdisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void bthasil_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bil2 = Convert.ToDecimal(txtdisplay.Text);
            {
                switch(opr)
                {
                    case 1:
                        txtdisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        txtdisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        txtdisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        txtdisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}
