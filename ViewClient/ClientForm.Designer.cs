namespace ViewClient
{
    partial class ClientForm
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
            this.DIsplay = new System.Windows.Forms.TextBox();
            this._buttonDisconnect = new System.Windows.Forms.Button();
            this._buttonSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._lableUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DIsplay
            // 
            this.DIsplay.AcceptsTab = true;
            this.DIsplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.DIsplay.Enabled = false;
            this.DIsplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DIsplay.Location = new System.Drawing.Point(13, 12);
            this.DIsplay.MaxLength = 2147483647;
            this.DIsplay.Multiline = true;
            this.DIsplay.Name = "DIsplay";
            this.DIsplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DIsplay.Size = new System.Drawing.Size(917, 500);
            this.DIsplay.TabIndex = 99;
            this.DIsplay.WordWrap = false;
            // 
            // _buttonDisconnect
            // 
            this._buttonDisconnect.Location = new System.Drawing.Point(13, 615);
            this._buttonDisconnect.Name = "_buttonDisconnect";
            this._buttonDisconnect.Size = new System.Drawing.Size(190, 46);
            this._buttonDisconnect.TabIndex = 2;
            this._buttonDisconnect.Text = "Disconnect";
            this._buttonDisconnect.UseVisualStyleBackColor = true;
            this._buttonDisconnect.Click += new System.EventHandler(this._buttonDisconnect_Click);
            // 
            // _buttonSend
            // 
            this._buttonSend.Location = new System.Drawing.Point(741, 615);
            this._buttonSend.Name = "_buttonSend";
            this._buttonSend.Size = new System.Drawing.Size(189, 46);
            this._buttonSend.TabIndex = 1;
            this._buttonSend.Text = "Send";
            this._buttonSend.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 518);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(917, 91);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // _lableUsername
            // 
            this._lableUsername.AutoSize = true;
            this._lableUsername.Location = new System.Drawing.Point(538, 626);
            this._lableUsername.Name = "_lableUsername";
            this._lableUsername.Size = new System.Drawing.Size(22, 24);
            this._lableUsername.TabIndex = 4;
            this._lableUsername.Text = "_";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.ControlBox = false;
            this.Controls.Add(this._lableUsername);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._buttonSend);
            this.Controls.Add(this._buttonDisconnect);
            this.Controls.Add(this.DIsplay);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DIsplay;
        private System.Windows.Forms.Button _buttonDisconnect;
        private System.Windows.Forms.Button _buttonSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _lableUsername;
    }
}