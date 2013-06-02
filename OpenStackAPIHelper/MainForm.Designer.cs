﻿namespace OpenStackAPIHelper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompute = new System.Windows.Forms.TabPage();
            this.bRetrieveFlavors = new System.Windows.Forms.Button();
            this.bRetrieveImages = new System.Windows.Forms.Button();
            this.lbFlavors = new System.Windows.Forms.ListBox();
            this.contextMenuServers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuCreateImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSMigrateLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSResetStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evacuateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.contextMenuImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createServerUsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServerDetails = new System.Windows.Forms.TextBox();
            this.bGetServers = new System.Windows.Forms.Button();
            this.lbServers = new System.Windows.Forms.ListBox();
            this.tabGet = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGetResults = new System.Windows.Forms.TextBox();
            this.bGetURL = new System.Windows.Forms.Button();
            this.tbGetUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPost = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPostBody = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPostResults = new System.Windows.Forms.TextBox();
            this.bPost = new System.Windows.Forms.Button();
            this.tbPostUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPut = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPutBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPutResults = new System.Windows.Forms.TextBox();
            this.bPut = new System.Windows.Forms.Button();
            this.tbPutUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDeleteResults = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.tbDeleteUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCompute.SuspendLayout();
            this.contextMenuServers.SuspendLayout();
            this.contextMenuImages.SuspendLayout();
            this.tabGet.SuspendLayout();
            this.tabPost.SuspendLayout();
            this.tabPut.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCompute);
            this.tabControl1.Controls.Add(this.tabGet);
            this.tabControl1.Controls.Add(this.tabPost);
            this.tabControl1.Controls.Add(this.tabPut);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCompute
            // 
            this.tabCompute.Controls.Add(this.bRetrieveFlavors);
            this.tabCompute.Controls.Add(this.bRetrieveImages);
            this.tabCompute.Controls.Add(this.lbFlavors);
            this.tabCompute.Controls.Add(this.lbImages);
            this.tabCompute.Controls.Add(this.label4);
            this.tabCompute.Controls.Add(this.tbServerDetails);
            this.tabCompute.Controls.Add(this.bGetServers);
            this.tabCompute.Controls.Add(this.lbServers);
            this.tabCompute.Location = new System.Drawing.Point(4, 22);
            this.tabCompute.Name = "tabCompute";
            this.tabCompute.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompute.Size = new System.Drawing.Size(846, 551);
            this.tabCompute.TabIndex = 0;
            this.tabCompute.Text = "Compute";
            this.tabCompute.UseVisualStyleBackColor = true;
            // 
            // bRetrieveFlavors
            // 
            this.bRetrieveFlavors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRetrieveFlavors.Location = new System.Drawing.Point(659, 6);
            this.bRetrieveFlavors.Name = "bRetrieveFlavors";
            this.bRetrieveFlavors.Size = new System.Drawing.Size(122, 23);
            this.bRetrieveFlavors.TabIndex = 13;
            this.bRetrieveFlavors.Text = "Retrieve Flavors";
            this.bRetrieveFlavors.UseVisualStyleBackColor = true;
            // 
            // bRetrieveImages
            // 
            this.bRetrieveImages.Location = new System.Drawing.Point(338, 6);
            this.bRetrieveImages.Name = "bRetrieveImages";
            this.bRetrieveImages.Size = new System.Drawing.Size(122, 23);
            this.bRetrieveImages.TabIndex = 12;
            this.bRetrieveImages.Text = "Retrieve Images";
            this.bRetrieveImages.UseVisualStyleBackColor = true;
            this.bRetrieveImages.Click += new System.EventHandler(this.bRetrieveImages_Click);
            // 
            // lbFlavors
            // 
            this.lbFlavors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFlavors.ContextMenuStrip = this.contextMenuServers;
            this.lbFlavors.FormattingEnabled = true;
            this.lbFlavors.Location = new System.Drawing.Point(521, 35);
            this.lbFlavors.Name = "lbFlavors";
            this.lbFlavors.Size = new System.Drawing.Size(319, 186);
            this.lbFlavors.TabIndex = 11;
            // 
            // contextMenuServers
            // 
            this.contextMenuServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCreateImage,
            this.toolStripMenuDelete,
            this.toolStripMenuReboot,
            this.changePasswordToolStripMenuItem,
            this.changeMetadataToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.confirmResizeToolStripMenuItem,
            this.revertResizeToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.unpauseToolStripMenuItem,
            this.suspendToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.migrateToolStripMenuItem,
            this.resetNetworkToolStripMenuItem,
            this.injectNetworkToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.unlockToolStripMenuItem,
            this.createBackupToolStripMenuItem,
            this.oSMigrateLiveToolStripMenuItem,
            this.oSResetStateToolStripMenuItem,
            this.evacuateToolStripMenuItem});
            this.contextMenuServers.Name = "contextMenuServers";
            this.contextMenuServers.Size = new System.Drawing.Size(169, 466);
            this.contextMenuServers.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuServers_Click);
            // 
            // toolStripMenuCreateImage
            // 
            this.toolStripMenuCreateImage.Name = "toolStripMenuCreateImage";
            this.toolStripMenuCreateImage.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuCreateImage.Text = "Create Image";
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuDelete.Text = "Delete";
            // 
            // toolStripMenuReboot
            // 
            this.toolStripMenuReboot.Name = "toolStripMenuReboot";
            this.toolStripMenuReboot.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuReboot.Text = "Reboot";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // changeMetadataToolStripMenuItem
            // 
            this.changeMetadataToolStripMenuItem.Name = "changeMetadataToolStripMenuItem";
            this.changeMetadataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changeMetadataToolStripMenuItem.Text = "Change Metadata";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            // 
            // confirmResizeToolStripMenuItem
            // 
            this.confirmResizeToolStripMenuItem.Name = "confirmResizeToolStripMenuItem";
            this.confirmResizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.confirmResizeToolStripMenuItem.Text = "Confirm Resize";
            // 
            // revertResizeToolStripMenuItem
            // 
            this.revertResizeToolStripMenuItem.Name = "revertResizeToolStripMenuItem";
            this.revertResizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.revertResizeToolStripMenuItem.Text = "Revert Resize";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // unpauseToolStripMenuItem
            // 
            this.unpauseToolStripMenuItem.Name = "unpauseToolStripMenuItem";
            this.unpauseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.unpauseToolStripMenuItem.Text = "Unpause";
            // 
            // suspendToolStripMenuItem
            // 
            this.suspendToolStripMenuItem.Name = "suspendToolStripMenuItem";
            this.suspendToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.suspendToolStripMenuItem.Text = "Suspend";
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            // 
            // migrateToolStripMenuItem
            // 
            this.migrateToolStripMenuItem.Name = "migrateToolStripMenuItem";
            this.migrateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.migrateToolStripMenuItem.Text = "Migrate";
            // 
            // resetNetworkToolStripMenuItem
            // 
            this.resetNetworkToolStripMenuItem.Name = "resetNetworkToolStripMenuItem";
            this.resetNetworkToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resetNetworkToolStripMenuItem.Text = "Reset Network";
            // 
            // injectNetworkToolStripMenuItem
            // 
            this.injectNetworkToolStripMenuItem.Name = "injectNetworkToolStripMenuItem";
            this.injectNetworkToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.injectNetworkToolStripMenuItem.Text = "Inject Network";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // unlockToolStripMenuItem
            // 
            this.unlockToolStripMenuItem.Name = "unlockToolStripMenuItem";
            this.unlockToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.unlockToolStripMenuItem.Text = "Unlock";
            // 
            // createBackupToolStripMenuItem
            // 
            this.createBackupToolStripMenuItem.Name = "createBackupToolStripMenuItem";
            this.createBackupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.createBackupToolStripMenuItem.Text = "Create Backup";
            // 
            // oSMigrateLiveToolStripMenuItem
            // 
            this.oSMigrateLiveToolStripMenuItem.Name = "oSMigrateLiveToolStripMenuItem";
            this.oSMigrateLiveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oSMigrateLiveToolStripMenuItem.Text = "OS Migrate Live";
            // 
            // oSResetStateToolStripMenuItem
            // 
            this.oSResetStateToolStripMenuItem.Name = "oSResetStateToolStripMenuItem";
            this.oSResetStateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oSResetStateToolStripMenuItem.Text = "OS Reset State";
            // 
            // evacuateToolStripMenuItem
            // 
            this.evacuateToolStripMenuItem.Name = "evacuateToolStripMenuItem";
            this.evacuateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.evacuateToolStripMenuItem.Text = "Evacuate";
            // 
            // lbImages
            // 
            this.lbImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImages.ContextMenuStrip = this.contextMenuImages;
            this.lbImages.FormattingEnabled = true;
            this.lbImages.Location = new System.Drawing.Point(289, 34);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(226, 186);
            this.lbImages.TabIndex = 10;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            this.lbImages.DoubleClick += new System.EventHandler(this.lbImages_DoubleClick);
            // 
            // contextMenuImages
            // 
            this.contextMenuImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.metadataToolStripMenuItem,
            this.createServerUsingToolStripMenuItem});
            this.contextMenuImages.Name = "contextMenuImages";
            this.contextMenuImages.Size = new System.Drawing.Size(185, 70);
            this.contextMenuImages.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuImages_ItemClicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            this.metadataToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.metadataToolStripMenuItem.Text = "Metadata";
            // 
            // createServerUsingToolStripMenuItem
            // 
            this.createServerUsingToolStripMenuItem.Name = "createServerUsingToolStripMenuItem";
            this.createServerUsingToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createServerUsingToolStripMenuItem.Text = "Create Server using...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Details";
            // 
            // tbServerDetails
            // 
            this.tbServerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServerDetails.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerDetails.Location = new System.Drawing.Point(48, 226);
            this.tbServerDetails.Multiline = true;
            this.tbServerDetails.Name = "tbServerDetails";
            this.tbServerDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServerDetails.Size = new System.Drawing.Size(792, 319);
            this.tbServerDetails.TabIndex = 8;
            this.tbServerDetails.Text = "blah\r\n     blah+5\r\n          blah + 10";
            // 
            // bGetServers
            // 
            this.bGetServers.Location = new System.Drawing.Point(52, 6);
            this.bGetServers.Name = "bGetServers";
            this.bGetServers.Size = new System.Drawing.Size(122, 23);
            this.bGetServers.TabIndex = 1;
            this.bGetServers.Text = "Retrieve Servers";
            this.bGetServers.UseVisualStyleBackColor = true;
            this.bGetServers.Click += new System.EventHandler(this.bGetServers_Click);
            // 
            // lbServers
            // 
            this.lbServers.ContextMenuStrip = this.contextMenuServers;
            this.lbServers.FormattingEnabled = true;
            this.lbServers.Location = new System.Drawing.Point(0, 34);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(283, 186);
            this.lbServers.TabIndex = 0;
            this.lbServers.SelectedIndexChanged += new System.EventHandler(this.lbServers_SelectedIndexChanged);
            this.lbServers.DoubleClick += new System.EventHandler(this.lbServers_DoubleClick);
            // 
            // tabGet
            // 
            this.tabGet.Controls.Add(this.label1);
            this.tabGet.Controls.Add(this.tbGetResults);
            this.tabGet.Controls.Add(this.bGetURL);
            this.tabGet.Controls.Add(this.tbGetUrl);
            this.tabGet.Controls.Add(this.label5);
            this.tabGet.Location = new System.Drawing.Point(4, 22);
            this.tabGet.Name = "tabGet";
            this.tabGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabGet.Size = new System.Drawing.Size(846, 535);
            this.tabGet.TabIndex = 1;
            this.tabGet.Text = "GET";
            this.tabGet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Results";
            // 
            // tbGetResults
            // 
            this.tbGetResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGetResults.Location = new System.Drawing.Point(6, 52);
            this.tbGetResults.Multiline = true;
            this.tbGetResults.Name = "tbGetResults";
            this.tbGetResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGetResults.Size = new System.Drawing.Size(834, 475);
            this.tbGetResults.TabIndex = 9;
            // 
            // bGetURL
            // 
            this.bGetURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGetURL.Location = new System.Drawing.Point(756, 6);
            this.bGetURL.Name = "bGetURL";
            this.bGetURL.Size = new System.Drawing.Size(75, 23);
            this.bGetURL.TabIndex = 6;
            this.bGetURL.Text = "GET";
            this.bGetURL.UseVisualStyleBackColor = true;
            this.bGetURL.Click += new System.EventHandler(this.bGetURL_Click);
            // 
            // tbGetUrl
            // 
            this.tbGetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGetUrl.Location = new System.Drawing.Point(67, 6);
            this.tbGetUrl.Name = "tbGetUrl";
            this.tbGetUrl.Size = new System.Drawing.Size(683, 20);
            this.tbGetUrl.TabIndex = 5;
            this.tbGetUrl.DoubleClick += new System.EventHandler(this.tbUrl_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "URL";
            // 
            // tabPost
            // 
            this.tabPost.Controls.Add(this.label7);
            this.tabPost.Controls.Add(this.tbPostBody);
            this.tabPost.Controls.Add(this.label11);
            this.tabPost.Controls.Add(this.tbPostResults);
            this.tabPost.Controls.Add(this.bPost);
            this.tabPost.Controls.Add(this.tbPostUrl);
            this.tabPost.Controls.Add(this.label2);
            this.tabPost.Location = new System.Drawing.Point(4, 22);
            this.tabPost.Name = "tabPost";
            this.tabPost.Size = new System.Drawing.Size(846, 535);
            this.tabPost.TabIndex = 2;
            this.tabPost.Text = "POST";
            this.tabPost.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "POST Body";
            // 
            // tbPostBody
            // 
            this.tbPostBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostBody.Location = new System.Drawing.Point(3, 43);
            this.tbPostBody.Multiline = true;
            this.tbPostBody.Name = "tbPostBody";
            this.tbPostBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPostBody.Size = new System.Drawing.Size(834, 186);
            this.tbPostBody.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Results";
            // 
            // tbPostResults
            // 
            this.tbPostResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostResults.Location = new System.Drawing.Point(6, 248);
            this.tbPostResults.Multiline = true;
            this.tbPostResults.Name = "tbPostResults";
            this.tbPostResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPostResults.Size = new System.Drawing.Size(834, 279);
            this.tbPostResults.TabIndex = 15;
            // 
            // bPost
            // 
            this.bPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPost.Location = new System.Drawing.Point(736, 3);
            this.bPost.Name = "bPost";
            this.bPost.Size = new System.Drawing.Size(75, 23);
            this.bPost.TabIndex = 9;
            this.bPost.Text = "POST";
            this.bPost.UseVisualStyleBackColor = true;
            // 
            // tbPostUrl
            // 
            this.tbPostUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostUrl.Location = new System.Drawing.Point(47, 3);
            this.tbPostUrl.Name = "tbPostUrl";
            this.tbPostUrl.Size = new System.Drawing.Size(683, 20);
            this.tbPostUrl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // tabPut
            // 
            this.tabPut.Controls.Add(this.label10);
            this.tabPut.Controls.Add(this.tbPutBody);
            this.tabPut.Controls.Add(this.label8);
            this.tabPut.Controls.Add(this.tbPutResults);
            this.tabPut.Controls.Add(this.bPut);
            this.tabPut.Controls.Add(this.tbPutUrl);
            this.tabPut.Controls.Add(this.label3);
            this.tabPut.Location = new System.Drawing.Point(4, 22);
            this.tabPut.Name = "tabPut";
            this.tabPut.Size = new System.Drawing.Size(846, 535);
            this.tabPut.TabIndex = 3;
            this.tabPut.Text = "PUT";
            this.tabPut.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "PUT Body";
            // 
            // tbPutBody
            // 
            this.tbPutBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPutBody.Location = new System.Drawing.Point(3, 43);
            this.tbPutBody.Multiline = true;
            this.tbPutBody.Name = "tbPutBody";
            this.tbPutBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPutBody.Size = new System.Drawing.Size(834, 186);
            this.tbPutBody.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Results";
            // 
            // tbPutResults
            // 
            this.tbPutResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPutResults.Location = new System.Drawing.Point(6, 248);
            this.tbPutResults.Multiline = true;
            this.tbPutResults.Name = "tbPutResults";
            this.tbPutResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPutResults.Size = new System.Drawing.Size(834, 279);
            this.tbPutResults.TabIndex = 11;
            // 
            // bPut
            // 
            this.bPut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPut.Location = new System.Drawing.Point(737, 3);
            this.bPut.Name = "bPut";
            this.bPut.Size = new System.Drawing.Size(75, 23);
            this.bPut.TabIndex = 9;
            this.bPut.Text = "PUT";
            this.bPut.UseVisualStyleBackColor = true;
            // 
            // tbPutUrl
            // 
            this.tbPutUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPutUrl.Location = new System.Drawing.Point(48, 3);
            this.tbPutUrl.Name = "tbPutUrl";
            this.tbPutUrl.Size = new System.Drawing.Size(683, 20);
            this.tbPutUrl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.label9);
            this.tabDelete.Controls.Add(this.tbDeleteResults);
            this.tabDelete.Controls.Add(this.bDelete);
            this.tabDelete.Controls.Add(this.tbDeleteUrl);
            this.tabDelete.Controls.Add(this.label6);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(846, 535);
            this.tabDelete.TabIndex = 4;
            this.tabDelete.Text = "DELETE";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Results";
            // 
            // tbDeleteResults
            // 
            this.tbDeleteResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeleteResults.Location = new System.Drawing.Point(6, 52);
            this.tbDeleteResults.Multiline = true;
            this.tbDeleteResults.Name = "tbDeleteResults";
            this.tbDeleteResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDeleteResults.Size = new System.Drawing.Size(834, 475);
            this.tbDeleteResults.TabIndex = 11;
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(741, 3);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "DELETE";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // tbDeleteUrl
            // 
            this.tbDeleteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeleteUrl.Location = new System.Drawing.Point(52, 3);
            this.tbDeleteUrl.Name = "tbDeleteUrl";
            this.tbDeleteUrl.Size = new System.Drawing.Size(683, 20);
            this.tbDeleteUrl.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "URL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "OpenStackAPIHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabCompute.ResumeLayout(false);
            this.tabCompute.PerformLayout();
            this.contextMenuServers.ResumeLayout(false);
            this.contextMenuImages.ResumeLayout(false);
            this.tabGet.ResumeLayout(false);
            this.tabGet.PerformLayout();
            this.tabPost.ResumeLayout(false);
            this.tabPost.PerformLayout();
            this.tabPut.ResumeLayout(false);
            this.tabPut.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCompute;
        private System.Windows.Forms.TabPage tabGet;
        private System.Windows.Forms.ListBox lbServers;
        private System.Windows.Forms.Button bGetServers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServerDetails;
        private System.Windows.Forms.TextBox tbGetUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bGetURL;
        private System.Windows.Forms.TextBox tbGetResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuServers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCreateImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReboot;
        private System.Windows.Forms.ListBox lbFlavors;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.Button bRetrieveFlavors;
        private System.Windows.Forms.Button bRetrieveImages;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmResizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertResizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSMigrateLiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSResetStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evacuateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuImages;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createServerUsingToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPost;
        private System.Windows.Forms.TabPage tabPut;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPost;
        private System.Windows.Forms.TextBox tbPostUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPut;
        private System.Windows.Forms.TextBox tbPutUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tbDeleteUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPutResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDeleteResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPutBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPostBody;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPostResults;
    }
}
