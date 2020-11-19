using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [System.Serializable]
    public class Message
    {
        public string from;
        public string to;
        public string text;        
        public MessageType messageType;

        public enum MessageType
        {
            playerID,
            playerMessage,
            gameInfo,
            lootInfo,
            privateMessage
        }
    }
}
