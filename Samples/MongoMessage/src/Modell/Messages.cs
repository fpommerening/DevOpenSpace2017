using System.Collections.Generic;

namespace FP.DevSpace2017.MongoMessage.Modell
{
    public class Messages
    {
        public Messages()
        {
            Entries = new List<Message>();
        }

        public List<Message> Entries { get; }
    }
}
