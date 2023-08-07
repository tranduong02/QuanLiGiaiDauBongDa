
namespace QuanLyGiaiDauBongDa
{
    partial class FrmListPlayer
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
            this.lvPlayer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvPlayer
            // 
            this.lvPlayer.HideSelection = false;
            this.lvPlayer.Location = new System.Drawing.Point(11, 12);
            this.lvPlayer.Name = "lvPlayer";
            this.lvPlayer.Size = new System.Drawing.Size(625, 457);
            this.lvPlayer.TabIndex = 6;
            this.lvPlayer.UseCompatibleStateImageBehavior = false;
            this.lvPlayer.SelectedIndexChanged += new System.EventHandler(this.lvPlayer_SelectedIndexChanged);
            // 
            // FrmListPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 479);
            this.Controls.Add(this.lvPlayer);
            this.Name = "FrmListPlayer";
            this.Text = "FrmListPlayer";
            this.Load += new System.EventHandler(this.FrmListPlayer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPlayer;
    }
}