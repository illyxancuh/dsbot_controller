using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsbot_controller
{
    class BotLoader
    {
        public static void Start(string bottoken)
        {
            try
            {
                new BotLoader().StartAsyncMsg(bottoken).GetAwaiter().GetResult();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла критическая ошибка\nВозможно токен бота введен неверно", "Критическая ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        public static DiscordSocketClient _client;
        public static bool isready;
        //private CommandHandler _handler;

        public async Task StartAsyncMsg(string bottoken)
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, bottoken);
            await _client.StartAsync().ContinueWith((x) =>isready = true);

            //_handler = new CommandHandler(_client);
                
            await Task.Delay(-1);
        }
    }
}
