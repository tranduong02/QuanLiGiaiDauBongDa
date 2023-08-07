namespace QuanLyGiaiDauBongDa
{
    partial class FrmAddCard
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
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(100, 38);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(274, 31);
            this.cbClub.TabIndex = 0;
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(100, 116);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(274, 31);
            this.cbPlayer.TabIndex = 1;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(27, 257);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(101, 27);
            this.rdbYellow.TabIndex = 2;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Thẻ vàng";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(187, 257);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(84, 27);
            this.rdbRed.TabIndex = 3;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Thẻ đỏ";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(100, 187);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(274, 30);
            this.txtTime.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Card";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Club";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // FrmAddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.rdbRed);
            this.Controls.Add(this.rdbYellow);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.cbClub);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmAddCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCard";
            this.Load += new System.EventHandler(this.FrmAddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}