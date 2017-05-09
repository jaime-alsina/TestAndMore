using Raet.Recruitment.Desing.ChatService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{
    /// <summary>
    /// Class to track the type of conversation
    /// </summary>
    public class Conversation
    {
        public Guid Id { get; set; }

        public ConversationType ConversationType { get; set; }

        public Guid UserId { get; set; }

        public MessageStatus MessageStatus { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateSent { get; set; }


    }
}
