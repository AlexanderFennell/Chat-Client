using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ChatClientForm
{
    public partial class Form1 : Form
    {

        //public List<string> connectedUserNames = new List<string>();
        string[] connectedUserNames = null;
        public string userName;
        public string message;
        public string messageToServer;

        public TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            chatMessageText.Text = "";
            connectedUserList.Text = "";
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
                client = new TcpClient("213.89.224.111", 8000);
                stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(userName);
                stream.Write(data, 0, data.Length);
                Task.Run(() => UpdateChatPanel());
            }
        }

        /// <summary>
        /// Sends message to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageSendButton_Click(object sender, EventArgs e)
        {
            if (userName == null) 
            {
                MessageBox.Show("Cannot send an a message without a profile");
            }
            else if(messageInputField.Text == null || messageInputField.Text == "")
            {
                MessageBox.Show("Cannot send an empty message");
            }
            else
            {
                message = messageInputField.Text;
                messageToServer = $"{userName}: {message}"; //Add timestamps to messages format "[12:00] Alex: Hello world"
                                                            //Send message to the server.
                byte[] data = Encoding.UTF8.GetBytes(messageToServer);
                stream.Write(data, 0, data.Length);
                
            }
                
        }

        private void UpdateChatPanel()
        {
            byte[] buffer = new byte[4028];
            while (true) 
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if ( bytesRead == 0)
                {
                    break;
                }
                
                message = Encoding.UTF8.GetString(buffer, 0 ,buffer.Length);
                //Todo add me: when client writes instead of username: 
                this.Invoke((MethodInvoker)(() =>
                {
                    if (message.StartsWith(userName))
                    {
                        chatMessageText.Text += message;
                        chatMessageText.Text += Environment.NewLine;
                        messageInputField.Clear();
                        
                    }
                    else if (message.StartsWith("/c/n"))
                    {
                        UpdateConnectedUsersText(message);
                    }
                    else
                    {
                        chatMessageText.Text += message;
                        chatMessageText.Text += Environment.NewLine;
                        messageInputField.Clear();


                    }
                    buffer = new byte[4028];
                }));
            }
            
        }

        private void UpdateConnectedUsersText(string message)
        {
            connectedUserList.Text = "";
            message = message.Replace("/c", "");
            connectedUserNames = Regex.Split(message, @"/n/");
            foreach (var user in connectedUserNames)
            {
                connectedUserList.Text += user;
                connectedUserList.Text += Environment.NewLine;
                Console.WriteLine($"loop: {message} | {user}");

            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
