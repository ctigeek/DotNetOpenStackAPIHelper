namespace OpenStackAPIHelper
{
    partial class FrmCreateImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbImageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lblNameOfServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbImageName
            // 
            this.tbImageName.Location = new System.Drawing.Point(121, 55);
            this.tbImageName.Name = "tbImageName";
            this.tbImageName.Size = new System.Drawing.Size(252, 20);
            this.tbImageName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Image";
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(230, 94);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(106, 23);
            this.bCreate.TabIndex = 2;
            this.bCreate.Text = "Create Image";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(62, 94);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(106, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lblNameOfServer
            // 
            this.lblNameOfServer.AutoSize = true;
            this.lblNameOfServer.Location = new System.Drawing.Point(89, 22);
            this.lblNameOfServer.Name = "lblNameOfServer";
            this.lblNameOfServer.Size = new System.Drawing.Size(79, 13);
            this.lblNameOfServer.TabIndex = 4;
            this.lblNameOfServer.Text = "Name of Image";
            // 
            // FrmCreateImage
            // 
            this.AcceptButton = this.bCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(418, 181);
            this.ControlBox = false;
            this.Controls.Add(this.lblNameOfServer);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCreateImage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateImage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lblNameOfServer;
    }
}