namespace ChatbotApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtBotOutput = new System.Windows.Forms.TextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBotOutput
            // 
            this.txtBotOutput.BackColor = System.Drawing.Color.Snow;
            this.txtBotOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBotOutput.Location = new System.Drawing.Point(12, 108);
            this.txtBotOutput.Multiline = true;
            this.txtBotOutput.Name = "txtBotOutput";
            this.txtBotOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBotOutput.Size = new System.Drawing.Size(304, 240);
            this.txtBotOutput.TabIndex = 0;
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInput.Location = new System.Drawing.Point(12, 354);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(234, 66);
            this.txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSend.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSend.Location = new System.Drawing.Point(252, 354);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 66);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send ↑";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "NEW LIFE\r\nASSISSTANT\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBotOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBotOutput;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

