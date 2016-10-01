namespace Praktikum_1___Komunikasi_Serial
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxReceiveData = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSendData = new System.Windows.Forms.RichTextBox();
            this.serialPortRS232 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(219, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 26);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(319, 18);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(94, 26);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(319, 224);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(94, 26);
            this.buttonSendData.TabIndex = 2;
            this.buttonSendData.Text = "Send";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data In";
            // 
            // richTextBoxReceiveData
            // 
            this.richTextBoxReceiveData.Location = new System.Drawing.Point(46, 266);
            this.richTextBoxReceiveData.Name = "richTextBoxReceiveData";
            this.richTextBoxReceiveData.Size = new System.Drawing.Size(367, 133);
            this.richTextBoxReceiveData.TabIndex = 7;
            this.richTextBoxReceiveData.Text = "";
            // 
            // richTextBoxSendData
            // 
            this.richTextBoxSendData.Location = new System.Drawing.Point(46, 73);
            this.richTextBoxSendData.Name = "richTextBoxSendData";
            this.richTextBoxSendData.Size = new System.Drawing.Size(367, 133);
            this.richTextBoxSendData.TabIndex = 6;
            this.richTextBoxSendData.Text = "";

            // 
            // serialPortRS232
            // 
            this.serialPortRS232.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRS232_DataReceived);
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(73, 17);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerial.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 424);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.richTextBoxReceiveData);
            this.Controls.Add(this.richTextBoxSendData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Praktikum 1 - Komunikasi Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxReceiveData;
        private System.Windows.Forms.RichTextBox richTextBoxSendData;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        public System.IO.Ports.SerialPort serialPortRS232;
    }
}

