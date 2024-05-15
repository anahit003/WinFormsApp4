using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public char separator = Convert.ToChar("-");
        //kodavorum
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length == 0) && (textBox_q.Text.Length == 0))
            {
                MessageBox.Show("Enter p and q!");
                return;
            }
            long p = Convert.ToInt64(textBox_p.Text);
            long q = Convert.ToInt64(textBox_q.Text);
            if (p < 31 || q < 31)
            {
                MessageBox.Show("p and q must be greater than 31");
                return;
            }

            if (!IsTheNumberSimple(p) || !IsTheNumberSimple(q))
            {
                MessageBox.Show("p or q - not prime numbers!");
                return;
            }
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m);
            long e_ = Calculate_e(d, m);
            textBox_Encrypted.Text = RSA_Endoce(textBox_ToEncrypt.Text, e_, n);
            textBox_d.Text = d.ToString();
            textBox_n.Text = n.ToString();
        }


        //vercanum
        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            if ((textBox_d.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox_d.Text);
                long n = Convert.ToInt64(textBox_n.Text);
                textBox_Decrypted.Text = RSA_Dedoce(textBox_Encrypted.Text, d, n);
            }
            else
                MessageBox.Show("Enter the secret key!");
        }

        //parz tvi stugum
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            for (long i = 2; i * i < n; i++)
                if (n % i == 0)

                    return false;
            return true;
        }
        //kodavorum
        private string RSA_Endoce(string s, long e, long n)
        {
            string result = "";
            BigInteger bi;
            for (int i = 0; i < s.Length; i++)
            {
                //int index = Array.IndexOf(characters, s[i]);
                int index = (int)s[i];
                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);
                BigInteger n_ = new BigInteger((int)n);
                bi = bi % n_;
                result += (bi.ToString()) + separator;
            }
            return result;
        }
        //vercanum
        private string RSA_Dedoce(string input, long d, long n)
        {
            string result = "";
            BigInteger bi;
            string[] strings = input.Split(separator);
            foreach (string item in strings)
            {
                if (item == "") { continue; }
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);
                bi = bi % n_;
                int index = Convert.ToInt32(bi.ToString());
                result += (char)index;
            }
            return result;
        }
        //d tvi hashvark, poxadarcabar parz e m-i het
        private long Calculate_d(long m)
        {
            long d = m - 1;
            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //ete unen yndhanur bajanarar
                {
                    d--;
                    i = 1;
                }
            return d;
        }
        //e tvi hashvark 
        private long Calculate_e(long d, long m)
        {
            long e = 10;
            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }
            return e;
        }
        private void Bt_NewPrimeNumbers_Click(object sender, EventArgs e)
        {
            int p = 0, q = 0;
            Random rnd = new Random();
            while (!IsTheNumberSimple(p))
            {
                p = rnd.Next(31, 211);
            }
            while (!IsTheNumberSimple(q) || q == p)
            {
                q = rnd.Next(31, 211);
            }
            textBox_p.Text = Convert.ToString(p);
            textBox_q.Text = Convert.ToString(q);
        }
        private void bt_FromDisk_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Files txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                textBox_ToEncrypt.Text = "";
                StreamReader sr = new StreamReader(OPF.FileName);
                while (!sr.EndOfStream)
                {
                    textBox_ToEncrypt.Text += sr.ReadLine();
                }
                sr.Close();
            }
        }



        private void bt_ToDisk_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVF = new SaveFileDialog();
            SVF.Filter = "Files txt|*.txt";
            if (SVF.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(SVF.FileName);
                sw.WriteLine(textBox_Encrypted.Text);
                sw.Close();
            }
        }

        private void bt_CalculateKey_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length == 0) && (textBox_q.Text.Length == 0))
            {
                MessageBox.Show("Enter p and q!");
                return;
            }
            long p = Convert.ToInt64(textBox_p.Text);
            long q = Convert.ToInt64(textBox_q.Text);
            if (p < 31 || q < 31)
            {
                MessageBox.Show("p and q must be greater than 31");
                return;
            }
            if (!IsTheNumberSimple(p) || !IsTheNumberSimple(q))
            {
                MessageBox.Show("p or q - not prime numbers!");
                return;
            }
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m);
            long e_ = Calculate_e(d, m);
            textBox_d.Text = d.ToString();
            textBox_n.Text = n.ToString();

        }

        private void textBox_Encrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

