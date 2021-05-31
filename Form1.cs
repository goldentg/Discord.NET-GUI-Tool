using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord.WebSocket;

namespace Discord.NET_GUI_Tool
{
    public partial class Form1 : Form
    {
        private DiscordSocketClient Client;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private async void connect_b_Click(object sender, EventArgs e)
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose,
                AlwaysDownloadUsers = true,
                MessageCacheSize = 200
            });

            Client.Log += Client_Log;

            try
            {
                await Client.LoginAsync(TokenType.Bot, token_tb.Text);
                await Client.StartAsync();
            }
            catch
            {
                MessageBox.Show("An error occurred when trying to connect to the Discord API using inputted token",
                    "ERROR");
                return;
            }

            await Task.Delay(3000);
        }

        private Task Client_Log(LogMessage arg)
        {
            Invoke((Action) delegate { console_output_rtb.AppendText(arg + "\n"); });
            return null;
        }
    }
}