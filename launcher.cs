using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RebelSpace
{
    public class Launcher : Form
    {
        private ComboBox serverList;
        private Button connectButton;
        private List<string> servers; // List of servers

        public Launcher()
        {
            // Initialize the list of servers
            servers = new List<string>
            {
                "Server 1 - 192.168.1.1",
                "Server 2 - 192.168.1.2",
                "Server 3 - 192.168.1.3"
            };

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configure the launcher window
            this.Text = "RebelSpace Launcher";
            this.Size = new System.Drawing.Size(400, 200);

            // Create and configure the server dropdown list
            serverList = new ComboBox();
            serverList.DataSource = servers;
            serverList.Location = new System.Drawing.Point(50, 50);
            serverList.Width = 300;

            // Create and configure the connect button
            connectButton = new Button();
            connectButton.Text = "Connect";
            connectButton.Location = new System.Drawing.Point(150, 100);
            connectButton.Click += ConnectButton_Click;

            // Add components to the form
            this.Controls.Add(serverList);
            this.Controls.Add(connectButton);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            // Get the selected server
            string selectedServer = serverList.SelectedItem.ToString();
            MessageBox.Show($"Connecting to {selectedServer}...");

            // Launch the main game window with the selected server
            var gameWindow = new GameWindow(selectedServer);
            gameWindow.Show();
            this.Hide();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }
    }
}