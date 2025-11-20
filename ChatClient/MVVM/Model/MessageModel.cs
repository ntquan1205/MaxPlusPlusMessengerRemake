using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVVM.Model
{
    public class MessageModel
    {
        public string Username { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public string UID { get; set; }

        public MessageModel()
        {
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Timestamp:HH:mm}] {Username}: {Content}";
        }
    }
}
