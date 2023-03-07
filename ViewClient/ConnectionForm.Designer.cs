namespace ViewClient
{
    partial class ConnectionForm
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
            this._textIPAdress = new System.Windows.Forms.TextBox();
            this._textPort = new System.Windows.Forms.TextBox();
            this._buttonConnect = new System.Windows.Forms.Button();
            this._buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._textUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _textIPAdress
            // 
            this._textIPAdress.Location = new System.Drawing.Point(131, 12);
            this._textIPAdress.Name = "_textIPAdress";
            this._textIPAdress.Size = new System.Drawing.Size(171, 34);
            this._textIPAdress.TabIndex = 0;
            this._textIPAdress.Text = "255.255.255.255";
            // 
            // _textPort
            // 
            this._textPort.Location = new System.Drawing.Point(131, 53);
            this._textPort.Name = "_textPort";
            this._textPort.Size = new System.Drawing.Size(171, 34);
            this._textPort.TabIndex = 1;
            this._textPort.Text = "65535";
            // 
            // _buttonConnect
            // 
            this._buttonConnect.Location = new System.Drawing.Point(241, 148);
            this._buttonConnect.Name = "_buttonConnect";
            this._buttonConnect.Size = new System.Drawing.Size(179, 43);
            this._buttonConnect.TabIndex = 3;
            this._buttonConnect.Text = "Connect";
            this._buttonConnect.UseVisualStyleBackColor = true;
            this._buttonConnect.Click += new System.EventHandler(this._buttonConnect_Click);
            // 
            // _buttonExit
            // 
            this._buttonExit.Location = new System.Drawing.Point(16, 148);
            this._buttonExit.Name = "_buttonExit";
            this._buttonExit.Size = new System.Drawing.Size(179, 43);
            this._buttonExit.TabIndex = 4;
            this._buttonExit.Text = "Exit";
            this._buttonExit.UseVisualStyleBackColor = true;
            this._buttonExit.Click += new System.EventHandler(this._buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserName:";
            // 
            // _textUserName
            // 
            this._textUserName.Location = new System.Drawing.Point(131, 93);
            this._textUserName.Name = "_textUserName";
            this._textUserName.Size = new System.Drawing.Size(289, 34);
            this._textUserName.TabIndex = 2;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.ControlBox = false;
            this.Controls.Add(this._textUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonExit);
            this.Controls.Add(this._buttonConnect);
            this.Controls.Add(this._textPort);
            this.Controls.Add(this._textIPAdress);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textIPAdress;
        private System.Windows.Forms.TextBox _textPort;
        private System.Windows.Forms.Button _buttonConnect;
        private System.Windows.Forms.Button _buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textUserName;
    }
}