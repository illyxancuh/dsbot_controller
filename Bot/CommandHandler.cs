using Discord.Commands;
using Discord.WebSocket;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;

namespace discordbot
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;
            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly(), null);

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;
            if (msg.Author.IsBot) { return; }
            if (msg.HasCharPrefix('!', ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos, null);
                if (msg.Author.IsBot) { return; }
                if (result.ErrorReason == "Object reference not set to an instance of an object.")
                {
                    await context.Channel.SendMessageAsync("Человек не создал профиль. Для создания профиля напишите !info или !info (и упомяните челоека)");
                }
                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }
            }
        }
    }
}