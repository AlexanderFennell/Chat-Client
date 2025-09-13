namespace ChatClientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.chatMessageText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectedUserList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nameInput = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.messageInputField = new System.Windows.Forms.TextBox();
            this.messageSendButton = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.chatMessageText);
            this.panel1.Location = new System.Drawing.Point(400, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 825);
            this.panel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(879, 14);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(11, 799);
            this.vScrollBar1.TabIndex = 3;
            // 
            // chatMessageText
            // 
            this.chatMessageText.AutoSize = true;
            this.chatMessageText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatMessageText.Location = new System.Drawing.Point(43, 34);
            this.chatMessageText.Name = "chatMessageText";
            this.chatMessageText.Size = new System.Drawing.Size(65, 26);
            this.chatMessageText.TabIndex = 2;
            this.chatMessageText.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.connectedUserList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1363, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 825);
            this.panel2.TabIndex = 0;
            // 
            // connectedUserList
            // 
            this.connectedUserList.AutoSize = true;
            this.connectedUserList.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedUserList.Location = new System.Drawing.Point(26, 49);
            this.connectedUserList.Name = "connectedUserList";
            this.connectedUserList.Size = new System.Drawing.Size(59, 26);
            this.connectedUserList.TabIndex = 3;
            this.connectedUserList.Text = "user1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected users";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(50, 274);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(264, 23);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Gray;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(50, 799);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(264, 72);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect to chat room";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.profileLabel);
            this.panel3.Location = new System.Drawing.Point(50, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 180);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.Location = new System.Drawing.Point(15, 14);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(87, 23);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "No profile";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Gray;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(50, 317);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(264, 68);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // messageInputField
            // 
            this.messageInputField.Location = new System.Drawing.Point(400, 877);
            this.messageInputField.Name = "messageInputField";
            this.messageInputField.Size = new System.Drawing.Size(627, 23);
            this.messageInputField.TabIndex = 0;
            // 
            // messageSendButton
            // 
            this.messageSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageSendButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSendButton.Location = new System.Drawing.Point(1053, 877);
            this.messageSendButton.Name = "messageSendButton";
            this.messageSendButton.Size = new System.Drawing.Size(75, 23);
            this.messageSendButton.TabIndex = 1;
            this.messageSendButton.Text = "Send";
            this.messageSendButton.UseVisualStyleBackColor = true;
            this.messageSendButton.Click += new System.EventHandler(this.messageSendButton_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(50, 750);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(264, 23);
            this.ipAddressTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1769, 974);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageSendButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.messageInputField);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Aleckez Super Chat Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button messageSendButton;
        private System.Windows.Forms.TextBox messageInputField;
        private System.Windows.Forms.Label chatMessageText;
        private System.Windows.Forms.Label connectedUserList;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label label3;
    }
}

