using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServisOtomasyon.Forms
{
    public partial class QrCode : Form
    {
        public QrCode()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qRCode = new QRCodeEncoder();
            pictureEdit1.Image = qRCode.Encode(textEdit1.Text);
        }
    }
}
