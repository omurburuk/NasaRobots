namespace NasaRobots
{
    partial class March
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(March));
            this._robot1 = new System.Windows.Forms.GroupBox();
            this.r1_Pers = new System.Windows.Forms.Label();
            this.r1_Y = new System.Windows.Forms.Label();
            this.r1_X = new System.Windows.Forms.Label();
            this._robot2 = new System.Windows.Forms.GroupBox();
            this.r2_X = new System.Windows.Forms.Label();
            this.r2_Y = new System.Windows.Forms.Label();
            this.r2_Pers = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this._robot1.SuspendLayout();
            this._robot2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // _robot1
            // 
            this._robot1.BackColor = System.Drawing.Color.Transparent;
            this._robot1.BackgroundImage = global::NasaRobots.Properties.Resources.ropot1;
            this._robot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._robot1.Controls.Add(this.r1_Pers);
            this._robot1.Controls.Add(this.r1_Y);
            this._robot1.Controls.Add(this.r1_X);
            this._robot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this._robot1.ForeColor = System.Drawing.Color.White;
            this._robot1.Location = new System.Drawing.Point(10, 360);
            this._robot1.Name = "_robot1";
            this._robot1.Size = new System.Drawing.Size(170, 220);
            this._robot1.TabIndex = 2;
            this._robot1.TabStop = false;
            this._robot1.Text = ".";
            this._robot1.MouseHover += new System.EventHandler(this._robot1_MouseHover);
            // 
            // r1_Pers
            // 
            this.r1_Pers.AutoSize = true;
            this.r1_Pers.ForeColor = System.Drawing.Color.White;
            this.r1_Pers.Location = new System.Drawing.Point(116, 167);
            this.r1_Pers.Name = "r1_Pers";
            this.r1_Pers.Size = new System.Drawing.Size(27, 20);
            this.r1_Pers.TabIndex = 2;
            this.r1_Pers.Tag = "Pers";
            this.r1_Pers.Text = "90";
            // 
            // r1_Y
            // 
            this.r1_Y.AutoSize = true;
            this.r1_Y.ForeColor = System.Drawing.Color.White;
            this.r1_Y.Location = new System.Drawing.Point(112, 46);
            this.r1_Y.Name = "r1_Y";
            this.r1_Y.Size = new System.Drawing.Size(36, 20);
            this.r1_Y.TabIndex = 1;
            this.r1_Y.Tag = "Y";
            this.r1_Y.Text = "400";
            // 
            // r1_X
            // 
            this.r1_X.AutoSize = true;
            this.r1_X.ForeColor = System.Drawing.Color.White;
            this.r1_X.Location = new System.Drawing.Point(112, 22);
            this.r1_X.Name = "r1_X";
            this.r1_X.Size = new System.Drawing.Size(27, 20);
            this.r1_X.TabIndex = 0;
            this.r1_X.Tag = "X";
            this.r1_X.Text = "30";
            // 
            // _robot2
            // 
            this._robot2.BackColor = System.Drawing.Color.Transparent;
            this._robot2.BackgroundImage = global::NasaRobots.Properties.Resources.robot2;
            this._robot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._robot2.Controls.Add(this.r2_X);
            this._robot2.Controls.Add(this.r2_Y);
            this._robot2.Controls.Add(this.r2_Pers);
            this._robot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this._robot2.ForeColor = System.Drawing.Color.White;
            this._robot2.Location = new System.Drawing.Point(800, 370);
            this._robot2.Name = "_robot2";
            this._robot2.Size = new System.Drawing.Size(170, 220);
            this._robot2.TabIndex = 3;
            this._robot2.TabStop = false;
            this._robot2.Text = ".";
            this._robot2.MouseHover += new System.EventHandler(this._robot2_MouseHover);
            // 
            // r2_X
            // 
            this.r2_X.AutoSize = true;
            this.r2_X.ForeColor = System.Drawing.Color.White;
            this.r2_X.Location = new System.Drawing.Point(109, 12);
            this.r2_X.Name = "r2_X";
            this.r2_X.Size = new System.Drawing.Size(36, 20);
            this.r2_X.TabIndex = 5;
            this.r2_X.Tag = "X";
            this.r2_X.Text = "800";
            // 
            // r2_Y
            // 
            this.r2_Y.AutoSize = true;
            this.r2_Y.BackColor = System.Drawing.Color.Transparent;
            this.r2_Y.ForeColor = System.Drawing.Color.White;
            this.r2_Y.Location = new System.Drawing.Point(109, 36);
            this.r2_Y.Name = "r2_Y";
            this.r2_Y.Size = new System.Drawing.Size(36, 20);
            this.r2_Y.TabIndex = 6;
            this.r2_Y.Tag = "Y";
            this.r2_Y.Text = "370";
            // 
            // r2_Pers
            // 
            this.r2_Pers.AutoSize = true;
            this.r2_Pers.BackColor = System.Drawing.Color.Transparent;
            this.r2_Pers.ForeColor = System.Drawing.Color.White;
            this.r2_Pers.Location = new System.Drawing.Point(109, 177);
            this.r2_Pers.Name = "r2_Pers";
            this.r2_Pers.Size = new System.Drawing.Size(27, 20);
            this.r2_Pers.TabIndex = 7;
            this.r2_Pers.Tag = "Pers";
            this.r2_Pers.Text = "90";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::NasaRobots.Properties.Resources.compass_PNG25572;
            this.pictureBox3.Location = new System.Drawing.Point(840, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send Katar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // March
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NasaRobots.Properties.Resources.space_315uqsztl4woiv3nk6xi4g;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this._robot2);
            this.Controls.Add(this._robot1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "March";
            this.Text = "March";
            this.Load += new System.EventHandler(this.March_Load);
            this.Shown += new System.EventHandler(this.March_Shown);
            this._robot1.ResumeLayout(false);
            this._robot1.PerformLayout();
            this._robot2.ResumeLayout(false);
            this._robot2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox _robot1;
        private System.Windows.Forms.GroupBox _robot2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label r1_Pers;
        private System.Windows.Forms.Label r1_Y;
        private System.Windows.Forms.Label r1_X;
        private System.Windows.Forms.Label r2_X;
        private System.Windows.Forms.Label r2_Y;
        private System.Windows.Forms.Label r2_Pers;
        private System.Windows.Forms.Button button1;
    }
}