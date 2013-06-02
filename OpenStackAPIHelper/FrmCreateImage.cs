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
    public partial class FrmCreateImage : Form
    {
        public FrmCreateImage()
        {
            InitializeComponent();
        }

        public string ImageName
        {
            get { return this.tbImageName.Text; }
            set { this.tbImageName.Text = value; }
        }
        public string ServerName
        {
            set { this.lblNameOfServer.Text = "Creating an image of server '" + value + "'."; }
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
