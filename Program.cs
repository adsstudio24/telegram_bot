using System;
using Telegram.Bot;

class TelegramBot
{
    static async System.Threading.Tasks.Task Main()
    {
        var botClient = new TelegramBotClient("YOUR_TELEGRAM_BOT_TOKEN");
        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Бот {me.Username} готовий!");
        
        botClient.StartReceiving(async (client, update, token) =>
        {
            if (update.Message != null)
            {
                await client.SendTextMessageAsync(update.Message.Chat.Id, "Привіт! Я Telegram-бот на C#.");
            }
        });
        
        Console.ReadLine();
    }
}