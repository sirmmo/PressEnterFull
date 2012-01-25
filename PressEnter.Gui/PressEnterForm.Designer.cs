namespace PressEnter.Gui
{
    partial class PressEnterForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._curStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._buttons = new System.Windows.Forms.TableLayoutPanel();
            this._pics = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pics)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._curStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _curStatus
            // 
            this._curStatus.Name = "_curStatus";
            this._curStatus.Size = new System.Drawing.Size(118, 17);
            this._curStatus.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._buttons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._pics);
            this.splitContainer1.Size = new System.Drawing.Size(284, 240);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            // 
            // _buttons
            // 
            this._buttons.ColumnCount = 1;
            this._buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttons.Location = new System.Drawing.Point(0, 0);
            this._buttons.Name = "_buttons";
            this._buttons.RowCount = 2;
            this._buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttons.Size = new System.Drawing.Size(94, 240);
            this._buttons.TabIndex = 0;
            // 
            // _pics
            // 
            this._pics.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pics.Location = new System.Drawing.Point(0, 0);
            this._pics.Name = "_pics";
            this._pics.Size = new System.Drawing.Size(186, 240);
            this._pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pics.TabIndex = 0;
            this._pics.TabStop = false;
            // 
            // PressEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PressEnterForm";
            this.Text = "PressEnterForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _curStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel _buttons;
        private System.Windows.Forms.PictureBox _pics;

    }
}