namespace Gymme
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TbDialogueBox = new System.Windows.Forms.TextBox();
            this.BtDialNext = new System.Windows.Forms.Button();
            this.BtDialBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(729, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TbDialogueBox
            // 
            this.TbDialogueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDialogueBox.Location = new System.Drawing.Point(232, 549);
            this.TbDialogueBox.Multiline = true;
            this.TbDialogueBox.Name = "TbDialogueBox";
            this.TbDialogueBox.Size = new System.Drawing.Size(491, 61);
            this.TbDialogueBox.TabIndex = 5;
            this.TbDialogueBox.Text = "...";
            this.TbDialogueBox.TextChanged += new System.EventHandler(this.TbDialogueBox_TextChanged);
            // 
            // BtDialNext
            // 
            this.BtDialNext.Location = new System.Drawing.Point(729, 564);
            this.BtDialNext.Name = "BtDialNext";
            this.BtDialNext.Size = new System.Drawing.Size(103, 30);
            this.BtDialNext.TabIndex = 6;
            this.BtDialNext.Text = "Next";
            this.BtDialNext.UseVisualStyleBackColor = true;
            this.BtDialNext.Click += new System.EventHandler(this.BtDialNext_Click);
            // 
            // BtDialBack
            // 
            this.BtDialBack.Location = new System.Drawing.Point(123, 564);
            this.BtDialBack.Name = "BtDialBack";
            this.BtDialBack.Size = new System.Drawing.Size(103, 30);
            this.BtDialBack.TabIndex = 7;
            this.BtDialBack.Text = "Back";
            this.BtDialBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 523);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtDialBack);
            this.Controls.Add(this.BtDialNext);
            this.Controls.Add(this.TbDialogueBox);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDialogueBox;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtDialNext;
        private System.Windows.Forms.Button BtDialBack;
        private System.Windows.Forms.Label label1;
    }
}