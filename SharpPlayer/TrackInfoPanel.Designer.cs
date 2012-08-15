namespace SharpPlayer
{
    partial class TrackInfoPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tagList = new System.Windows.Forms.ListBox();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.RemoveTagBtn = new System.Windows.Forms.Button();
            this.ratingPanel = new SharpPlayer.RatingPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 66.66666F ) );
            this.tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.33333F ) );
            this.tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
            this.tableLayoutPanel.Controls.Add( this.ratingPanel, 3, 1 );
            this.tableLayoutPanel.Controls.Add( this.label1, 2, 1 );
            this.tableLayoutPanel.Controls.Add( this.tagList, 0, 0 );
            this.tableLayoutPanel.Controls.Add( this.addTagBtn, 0, 1 );
            this.tableLayoutPanel.Controls.Add( this.RemoveTagBtn, 1, 1 );
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            this.tableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle() );
            this.tableLayoutPanel.Size = new System.Drawing.Size( 256, 160 );
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point( 103, 130 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 38, 30 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Rating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tagList
            // 
            this.tableLayoutPanel.SetColumnSpan( this.tagList, 4 );
            this.tagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagList.FormattingEnabled = true;
            this.tagList.Location = new System.Drawing.Point( 3, 3 );
            this.tagList.Name = "tagList";
            this.tagList.Size = new System.Drawing.Size( 250, 124 );
            this.tagList.TabIndex = 2;
            // 
            // addTagBtn
            // 
            this.addTagBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTagBtn.Image = global::SharpPlayer.Properties.Resources.tag_label;
            this.addTagBtn.Location = new System.Drawing.Point( 3, 133 );
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size( 61, 24 );
            this.addTagBtn.TabIndex = 3;
            this.addTagBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveTagBtn
            // 
            this.RemoveTagBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveTagBtn.Image = global::SharpPlayer.Properties.Resources.tag__minus;
            this.RemoveTagBtn.Location = new System.Drawing.Point( 70, 133 );
            this.RemoveTagBtn.Name = "RemoveTagBtn";
            this.RemoveTagBtn.Size = new System.Drawing.Size( 27, 24 );
            this.RemoveTagBtn.TabIndex = 4;
            this.RemoveTagBtn.UseVisualStyleBackColor = true;
            // 
            // ratingPanel
            // 
            this.ratingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ratingPanel.Location = new System.Drawing.Point( 147, 133 );
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Rating = SharpPlayer.Rating.None;
            this.ratingPanel.Size = new System.Drawing.Size( 104, 24 );
            this.ratingPanel.TabIndex = 0;
            // 
            // TrackInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add( this.tableLayoutPanel );
            this.Name = "TrackInfoPanel";
            this.Size = new System.Drawing.Size( 256, 160 );
            this.tableLayoutPanel.ResumeLayout( false );
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private RatingPanel ratingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox tagList;
        private System.Windows.Forms.Button addTagBtn;
        private System.Windows.Forms.Button RemoveTagBtn;
    }
}
