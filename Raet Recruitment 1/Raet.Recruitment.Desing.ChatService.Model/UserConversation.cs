using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{
    /// <summary>
    /// class to keep track if a conversation has been sent
    /// </summary>
    public class UserConversation
    {
        public Guid Id { get; set; }

        public Guid ConversationId { get; set; }

        public bool MessageReceived { get; set; }

    }
}
