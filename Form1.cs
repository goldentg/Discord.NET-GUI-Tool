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

        private async void connect_b_Click(object sender, EventArgs e)
        {
            //Create a new socket client
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                //API settings
                LogLevel = LogSeverity.Verbose,
                AlwaysDownloadUsers = true,
                MessageCacheSize = 200
            });

            Client.Log += Client_Log;

            try
            {
                //Login to API with token provided in token_tb field
                await Client.LoginAsync(TokenType.Bot, token_tb.Text);
                await Client.StartAsync();
            }
            catch
            {
                //If error occurred when connecting to the API with inputted token create an error popup
                MessageBox.Show("An error occurred when trying to connect to the Discord API using inputted token",
                    "ERROR");
                return;
            }

            await Task.Delay(3000);
        }

        private Task Client_Log(LogMessage arg)
        {
            //Display console output/logging to console_output_rtb
            Invoke((Action) delegate { console_output_rtb.AppendText(arg + "\n"); });
            return null;
        }
    }
}