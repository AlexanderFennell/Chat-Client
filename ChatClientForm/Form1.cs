using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ChatClientForm
{
    public partial class Form1 : Form
    {

        public List<string> connectedUserNames = new List<string>();
        public string userName;
        public string message;
        public string messageToServer;
        public Form1()
        {
            InitializeComponent();
            chatMessageText.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == null || nameInput.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                userName = nameInput.Text;
                profileLabel.Text = $"User: {userName}";
                MessageBox.Show(userName);
            }    
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (userName == null)
            {
                MessageBox.Show("Cannot connect to server without a profile created.");
            }
            else
            {

            }
        }

        /// <summary>
        /// Sends message to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageSendButton_Click(object sender, EventArgs e)
        {
            if (messageInputField.Text == null || messageInputField.Text == "")
            {
                MessageBox.Show("Cannot send an empty message");
            }
            else
            {
                message = messageInputField.Text;
                messageToServer = $"{userName}: {message}"; //Add timestamps to messages format "[12:00] Alex: Hello world"
                                                            //Send message to the server.
                chatMessageText.Text += messageToServer + Environment.NewLine;
                messageInputField.Clear();
            }
                
        }

        private void UpdateChatPanel()
        {
            
        }
        private void UpdateConnectedUsersText()
        {
            foreach (var user in connectedUserNames)
            {
                connectedUserList.Text += user + Environment.NewLine;
               
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
