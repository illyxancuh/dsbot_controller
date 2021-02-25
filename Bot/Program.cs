using Discord;
using Discord.WebSocket;
using discordbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    class Program
    {
        public static void Start()
        => new Program().StartAsyncMsg().GetAwaiter().GetResult();

        public static DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsyncMsg()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, Form1.botid);
            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}
