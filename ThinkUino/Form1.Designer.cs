namespace ThinkUino
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnHeadsetConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.lblAttention = new System.Windows.Forms.Label();
            this.txtHeadsetDebug = new System.Windows.Forms.TextBox();
            this.btnHeadsetDisconnect = new System.Windows.Forms.Button();
            this.serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.blink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHeadsetConnect
            // 
            this.btnHeadsetConnect.Location = new System.Drawing.Point(63, 33);
            this.btnHeadsetConnect.Name = "btnHeadsetConnect";
            this.btnHeadsetConnect.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsetConnect.TabIndex = 0;
            this.btnHeadsetConnect.Text = "Connect";
            this.btnHeadsetConnect.UseVisualStyleBackColor = true;
            this.btnHeadsetConnect.Click += new System.EventHandler(this.btnHeadsetConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMeditation);
            this.groupBox1.Controls.Add(this.lblAttention);
            this.groupBox1.Controls.Add(this.txtHeadsetDebug);
            this.groupBox1.Controls.Add(this.btnHeadsetDisconnect);
            this.groupBox1.Controls.Add(this.btnHeadsetConnect);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headset";
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Location = new System.Drawing.Point(89, 171);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(59, 13);
            this.lblMeditation.TabIndex = 4;
            this.lblMeditation.Text = "Meditation:";
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(6, 171);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(52, 13);
            this.lblAttention.TabIndex = 3;
            this.lblAttention.Text = "Attention:";
            // 
            // txtHeadsetDebug
            // 
            this.txtHeadsetDebug.Location = new System.Drawing.Point(6, 101);
            this.txtHeadsetDebug.Multiline = true;
            this.txtHeadsetDebug.Name = "txtHeadsetDebug";
            this.txtHeadsetDebug.Size = new System.Drawing.Size(188, 70);
            this.txtHeadsetDebug.TabIndex = 2;
            // 
            // btnHeadsetDisconnect
            // 
            this.btnHeadsetDisconnect.Enabled = false;
            this.btnHeadsetDisconnect.Location = new System.Drawing.Point(63, 62);
            this.btnHeadsetDisconnect.Name = "btnHeadsetDisconnect";
            this.btnHeadsetDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsetDisconnect.TabIndex = 1;
            this.btnHeadsetDisconnect.Text = "Disconnect";
            this.btnHeadsetDisconnect.UseVisualStyleBackColor = true;
            this.btnHeadsetDisconnect.Click += new System.EventHandler(this.btnHeadsetDisconnect_Click);
            // 
            // serialArduino
            // 
            this.serialArduino.PortName = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antonio Blescia - www.blesciasw.it";
            // 
            // blink
            // 
            this.blink.Location = new System.Drawing.Point(12, 209);
            this.blink.Name = "blink";
            this.blink.Size = new System.Drawing.Size(201, 20);
            this.blink.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkUino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeadsetConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHeadsetDebug;
        private System.Windows.Forms.Button btnHeadsetDisconnect;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblMeditation;
        private System.IO.Ports.SerialPort serialArduino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blink;
        private System.Windows.Forms.Button button1;

    }
}

