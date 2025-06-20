using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManager
{
    public partial class ChatForm : Form
    {
        // Reference to the current user
        private User currentUser;

        // SignalR connection to the chat hub
        private HubConnection connection;

        // Reference to the HubForm
        private HubForm hubForm;

        public ChatForm()
        {
            InitializeComponent();
        }

        // Constructor that initializes the chat form with a user and a reference to the HubForm.
        public ChatForm(User user, HubForm hubForm)
        {
            InitializeComponent();
            InitializeSignalR();
            currentUser = user;
            lbl_username.Text = $"{currentUser.Username}";
            this.hubForm = hubForm;
        }

        // Initializes the SignalR connection to the chat hub and sets up the event handler for receiving messages.
        private async void InitializeSignalR()
        {
            // Create a new HubConnection to the chat hub
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7203/chathub")
                .Build();

            // Set up the event handler for receiving messages
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                // Invoke the UI thread to update the list box with the received message
                Invoke((Action)(() =>
                {
                    listBox1.Items.Add($"{user}: {message}");
                }));
            });

            try
            {
                // Start the connection to the hub
                await connection.StartAsync();
                MessageBox.Show("Connected to the chat server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the chat server: {ex.Message}");
            }
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            // Send the message to the server
            string user = currentUser.Username;
            string message = txt_message.Text;

            // Check if the user and message are not empty
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(message))
            {
                try
                {
                    // Invoke the SendMessage method on the hub
                    await connection.InvokeAsync("SendMessage", user, message);
                    txt_message.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending message: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter both user and message.");
            }
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hubForm.Show();
            this.Hide();
        }
    }
}
