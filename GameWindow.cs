using System;
using System.Windows.Forms;

namespace RebelSpace
{
    public class GameWindow : Form
    {
        public GameWindow()
        {
            this.Text = "RebelSpace - Version 0.1 AL";
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true; // Для сглаживания графики
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameWindow());
        }
    }
}