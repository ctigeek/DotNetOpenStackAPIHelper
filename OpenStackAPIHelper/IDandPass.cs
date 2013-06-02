using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStackAPIHelper
{
    public partial class IDandPass : Form
    {
        public IDandPass()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return this.tbId.Text; }
        }
        public string Password
        {
            get { return this.tbPassword.Text; }
        }
        

        private void bOk_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
