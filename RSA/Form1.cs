using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {

            //RSA测试实例
            string oldData = txt_Encrypt.Text;
            RSA rsa = new RSA();
            rsa.CreateRSAKey();
            string newData = rsa.RSAEncrypt(oldData);
            txt_Decrypt.Text = newData;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //RSA测试实例
            string oldData = txt_Encrypt.Text;
            RSA rsa = new RSA();
            //rsa.CreateRSAKey();
            string newData = rsa.RSADecrypt(oldData);
            txt_Decrypt.Text = newData;
        }
    }
}
