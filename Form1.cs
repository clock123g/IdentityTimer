using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identity2MTimer
{
    public partial class Form1 : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (msg.Msg == 0x100)
                kyo2();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void kyo2()
        {   timer1.Enabled = true;
            c = 120;

        }

        static int c = 120;

        private void timer1_Tick(object sender, EventArgs e)
        {
            --c;
            label1.Text = c.ToString();
            if (c <= 0)
            {
                System.Media.SystemSounds.Hand.Play();
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kyo2();
        }
    }
}
