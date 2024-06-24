using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TinhHT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double TinhS(double r) { return r * r * Math.PI; }
        double TinhP(double r) { return 2 * Math.PI * r; }


        private void btnTinh_Click(object sender, EventArgs e)
        {
            double r;
            if (double.TryParse(txtR.Text, out r) && r >= 0)
            {
                double P, S;
                r = Convert.ToDouble(txtR.Text);
                P = TinhP(r);
                S = TinhS(r);
                txtKQ1.Text = P.ToString();
                txtKQ2.Text = S.ToString();   
            }
            else
            {
                MessageBox.Show("Phai nhap ban kinh", "Nhap ban kinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao = "";
            if (rdbCV.Checked)
            {
                double r;

                if (double.TryParse(txtR.Text, out r) && r >= 0)
                {
                    double P;
                    r = Convert.ToDouble(txtR.Text);
                    P = TinhP(r);
                    thongbao += "P = " + P.ToString() + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Phai nhap ban kinh", "Nhap ban kinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (rdbDT.Checked)
            {
                double r;
                if (double.TryParse(txtR.Text, out r) && r>= 0)
                {
                    double S;
                    r = Convert.ToDouble(txtR.Text);
                    S = TinhS(r);
                    thongbao += "S = " + S.ToString() + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Phai nhap ban kinh", "Nhap ban kinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui long chon tinh nang", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtR.Text);
            string thongbao = "";
            if (chkCV.Checked)
            {
                double P = TinhP(r);
                thongbao = thongbao + "-P = " + Convert.ToString(P) + Environment.NewLine;
            }
            if (chkDT.Checked)
            {
                double S = TinhS(r);
                thongbao = thongbao + "-S = " + Convert.ToString(S) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui long chon tinh nang", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
