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
            this.Display = new System.Windows.Forms.TextBox();
            this._buttonDisconnect = new System.Windows.Forms.Button();
            this._buttonSend = new System.Windows.Forms.Button();
            this._textMessage = new System.Windows.Forms.TextBox();
            this._lableUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AcceptsReturn = true;
            this.Display.AcceptsTab = true;
            this.Display.AllowDrop = true;
            this.Display.Cursor = System.Windows.Forms.Cursors.Default;
            this.Display.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Display.Location = new System.Drawing.Point(13, 12);
            this.Display.MaxLength = 2147483647;
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Display.Size = new System.Drawing.Size(917, 500);
            this.Display.TabIndex = 99;
            this.Display.WordWrap = false;
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
            this._buttonSend.Click += new System.EventHandler(this._buttonSend_Click);
            // 
            // _textMessage
            // 
            this._textMessage.Location = new System.Drawing.Point(13, 518);
            this._textMessage.Multiline = true;
            this._textMessage.Name = "_textMessage";
            this._textMessage.Size = new System.Drawing.Size(917, 91);
            this._textMessage.TabIndex = 0;
            this._textMessage.WordWrap = false;
            // 
            // _lableUsername
            // 
            this._lableUsername.AutoSize = true;
            this._lableUsername.Location = new System.Drawing.Point(538, 626);
            this._lableUsername.Name = "_lableUsername";
            this._lableUsername.Size = new System.Drawing.Size(24, 25);
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
            this.Controls.Add(this._textMessage);
            this.Controls.Add(this._buttonSend);
            this.Controls.Add(this._buttonDisconnect);
            this.Controls.Add(this.Display);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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

        private System.Windows.Forms.TextBox _textMessage;

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button _buttonDisconnect;
        private System.Windows.Forms.Button _buttonSend;
        private System.Windows.Forms.Label _lableUsername;
    }
}