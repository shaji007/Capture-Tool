using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture_Tool
{
    public partial class AddCaption : Form
    {
        public AddCaption()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLabel(string text)
        {
            lbText.Text = text;
        }

        public void setSingleLine()
        {
            tbData.Multiline = false;
        }

        public string getData()
        {
            return tbData.Text;
        }
    }
}
