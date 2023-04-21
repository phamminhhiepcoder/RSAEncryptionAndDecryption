using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace primeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        public static bool IsPrime(int num)
        {
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) 
                    return false;
            }
            return num > 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int num, i, ctr;
            int eNum = 0;
            int bat_dau = Convert.ToInt32(nudPNumber.Value);
            int ket_thuc = Convert.ToInt32(nudQNumber.Value);
            List<int> mangso = new List<int>();
            for (num = 1; num <= 1000; num++)
            {
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                {
                    mangso.Add(num);
                }
            }
            int NNum = bat_dau * ket_thuc;
            txtNNumber.Text = NNum.ToString();
            int phiNum = (bat_dau - 1) * (ket_thuc - 1);
            txtPhiNumber.Text = phiNum.ToString();
            //foreach (int so in mangso.Reverse<int>())
            foreach (int so in mangso.Reverse<int>())
            {
                if (GCD(so, phiNum) == 1)
                {
                    eNum = so;
                    txtENumber.Text = eNum.ToString();
                    break;
                }
            }
            double dNum = 0;
            double res = 0;
            for (dNum = 2; ; dNum++)
            {
                res = (dNum * eNum) % phiNum;
                if (res == 1)
                {
                    txtDNumber.Text = dNum.ToString();
                    break;
                }
            }
            label7.Text = "Public key: (" + eNum + "," + NNum + ")";
            label8.Text = "Private key: (" + dNum + "," + NNum + ")";
            //}
            //else
            //{
            // MessageBox.Show("Vui lòng chọn số nguyên tố!");
            //}                        
        }
        List<BigInteger> mang = new List<BigInteger>();
        List<BigInteger> giaima = new List<BigInteger>();
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            txtVanBanMaHoa.Clear();
            BigInteger number = 0;
            string encrypt = "";

            string s = txtVanBanGoc.Text;
            int eNum = Convert.ToInt32(txtENumber.Text);
            int N = Convert.ToInt32(txtNNumber.Text);

            foreach (char c in s)
            {
                number = BigInteger.Pow((int)c, eNum) % N;
                //Console.Write("encrypt text: "+(char)number);
                encrypt += (char)number;
                mang.Add(number);

            }
            string mh = "";
            foreach (BigInteger c in mang)
            {
                mh += (char)c;
            }
            txtVanBanMaHoa.Text = mh;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            int dNum = Convert.ToInt32(txtDNumber.Text);
            int N = Convert.ToInt32(txtNNumber.Text);
            txtVanBanGiaiMa.Clear();
            string mh = "";
            BigInteger number1 = 0;
            string decrypt = "";
            foreach (BigInteger c in mang)
            {
                number1 = BigInteger.Pow(c, dNum) % N;
                giaima.Add(number1);
                decrypt += (char)number1;

            }
            foreach (BigInteger a in giaima)
            {
                mh+=(char)a;
            }
            txtVanBanGiaiMa.Text = mh;           
        }







        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult btndatlai = MessageBox.Show("Bạn có muốn xoá dữ liệu không", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (btndatlai == DialogResult.Yes)
            {
                txtVanBanMaHoa.Clear();
                txtVanBanGiaiMa.Clear();
                txtVanBanGoc.Clear();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult btnThoat = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btnThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
