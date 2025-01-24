// File: Launcher.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RebelSpace.Engine; // Добавьте эту строку

namespace RebelSpace
{
    public class Launcher : Form
    {
        private ComboBox serverList;
        private Button connectButton;
        private List<string> servers; // Список серверов

        public Launcher()
        {
            // Инициализация списка серверов
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
            // Настройка окна лаунчера
            this.Text = "RebelSpace Launcher";
            this.Size = new System.Drawing.Size(400, 200);

            // Создание и настройка выпадающего списка серверов
            serverList = new ComboBox();
            serverList.DataSource = servers;
            serverList.Location = new System.Drawing.Point(50, 50);
            serverList.Width = 300;

            // Создание и настройка кнопки подключения
            connectButton = new Button();
            connectButton.Text = "Connect";
            connectButton.Location = new System.Drawing.Point(150, 100);
            connectButton.Click += ConnectButton_Click;

            // Добавление элементов на форму
            this.Controls.Add(serverList);
            this.Controls.Add(connectButton);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            // Получение выбранного сервера
            string selectedServer = serverList.SelectedItem.ToString();
            MessageBox.Show($"Connecting to {selectedServer}...");

            // Здесь можно добавить логику подключения к серверу и запуску игры
            // Например:
            GameEngine gameEngine = new GameEngine(selectedServer);
            gameEngine.Run();
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