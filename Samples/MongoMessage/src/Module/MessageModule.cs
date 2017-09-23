using System.Threading.Tasks;
using test1.Data;
using test1.Model;
using Nancy.ModelBinding;

namespace test1.Modules
{
    public class MessageModule : Nancy.NancyModule
    {
        public MessageModule(MessageRepository messageRepo)
        {
            Get("/", async args =>
            {
                var messages = await GetMessages(messageRepo);
                return View["Messages", messages];
            });

            Get("/Message/", args => View["Message"]);

            Post("/Message", async args =>
            {
                var message = this.Bind<Message>();
                await messageRepo.SaveMessage(message.UserName, message.Content);
                var messages = await GetMessages(messageRepo);
                return View["Messages", messages];
            });
        }

        private static async Task<Messages> GetMessages(MessageRepository messageRepo)
        {
            var dto = await messageRepo.GetMessages();
            var messages = new Messages();
            foreach (var msg in dto)
            {
                messages.Entries.Add(new Message
                {
                    Content = msg.Content,
                    UserName = msg.User,
                    Timestamp = msg.Timestamp
                });
            }
            return messages;
        }
    }
}
