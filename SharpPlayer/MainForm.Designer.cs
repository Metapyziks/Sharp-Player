namespace SharpPlayer
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trackListView = new System.Windows.Forms.ListView();
            this.trackNoHeader = ( (System.Windows.Forms.ColumnHeader) ( new System.Windows.Forms.ColumnHeader() ) );
            this.artistHeader = ( (System.Windows.Forms.ColumnHeader) ( new System.Windows.Forms.ColumnHeader() ) );
            this.titleHeader = ( (System.Windows.Forms.ColumnHeader) ( new System.Windows.Forms.ColumnHeader() ) );
            this.lengthHeader = ( (System.Windows.Forms.ColumnHeader) ( new System.Windows.Forms.ColumnHeader() ) );
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumArtPanel = new SharpPlayer.AlbumArtPanel();
            this.trackInfoPanel = new SharpPlayer.TrackInfoPanel();
            this.mainLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 262F ) );
            this.mainLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.mainLayoutPanel.Controls.Add( this.albumArtPanel, 0, 1 );
            this.mainLayoutPanel.Controls.Add( this.trackInfoPanel, 0, 2 );
            this.mainLayoutPanel.Controls.Add( this.trackListView, 1, 0 );
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point( 0, 24 );
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.mainLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.mainLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.mainLayoutPanel.Size = new System.Drawing.Size( 1024, 616 );
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // trackListView
            // 
            this.trackListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackListView.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.trackNoHeader,
            this.titleHeader,
            this.artistHeader,
            this.lengthHeader} );
            this.trackListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackListView.FullRowSelect = true;
            this.trackListView.GridLines = true;
            this.trackListView.Location = new System.Drawing.Point( 265, 3 );
            this.trackListView.MultiSelect = false;
            this.trackListView.Name = "trackListView";
            this.mainLayoutPanel.SetRowSpan( this.trackListView, 3 );
            this.trackListView.Size = new System.Drawing.Size( 756, 610 );
            this.trackListView.TabIndex = 2;
            this.trackListView.UseCompatibleStateImageBehavior = false;
            this.trackListView.View = System.Windows.Forms.View.Details;
            this.trackListView.Resize += new System.EventHandler( this.trackListView_Resize );
            // 
            // trackNoHeader
            // 
            this.trackNoHeader.Text = "#";
            this.trackNoHeader.Width = 32;
            // 
            // artistHeader
            // 
            this.artistHeader.Text = "Artist";
            this.artistHeader.Width = 351;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 330;
            // 
            // lengthHeader
            // 
            this.lengthHeader.Text = "Length";
            this.lengthHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lengthHeader.Width = 48;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.collapseToolStripMenuItem} );
            this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size( 1024, 24 );
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.addFilesToolStripMenuItem.Text = "Add Files...";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.addFolderToolStripMenuItem.Text = "Add Folder...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 138, 6 );
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.control_stop_square;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.control;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.control_pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.control_stop_180;
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.control_stop;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Image = global::SharpPlayer.Properties.Resources.application_sidebar_collapse;
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size( 28, 20 );
            this.collapseToolStripMenuItem.Click += new System.EventHandler( this.collapseToolStripMenuItem_Click );
            // 
            // albumArtPanel
            // 
            this.albumArtPanel.BackColor = System.Drawing.Color.White;
            this.albumArtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.albumArtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumArtPanel.Location = new System.Drawing.Point( 3, 166 );
            this.albumArtPanel.Name = "albumArtPanel";
            this.albumArtPanel.Size = new System.Drawing.Size( 256, 256 );
            this.albumArtPanel.TabIndex = 0;
            // 
            // trackInfoPanel
            // 
            this.trackInfoPanel.BackColor = System.Drawing.Color.White;
            this.trackInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackInfoPanel.Enabled = false;
            this.trackInfoPanel.Location = new System.Drawing.Point( 3, 428 );
            this.trackInfoPanel.Name = "trackInfoPanel";
            this.trackInfoPanel.Size = new System.Drawing.Size( 256, 185 );
            this.trackInfoPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1024, 640 );
            this.Controls.Add( this.mainLayoutPanel );
            this.Controls.Add( this.menuStrip );
            this.MinimumSize = new System.Drawing.Size( 278, 512 );
            this.Name = "MainForm";
            this.Text = "Sharp Player";
            this.mainLayoutPanel.ResumeLayout( false );
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private AlbumArtPanel albumArtPanel;
        private TrackInfoPanel trackInfoPanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem;
        private System.Windows.Forms.ListView trackListView;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader trackNoHeader;
        private System.Windows.Forms.ColumnHeader artistHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader lengthHeader;
    }
}

