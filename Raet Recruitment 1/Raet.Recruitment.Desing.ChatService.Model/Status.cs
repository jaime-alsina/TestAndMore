using Raet.Recruitment.Desing.ChatService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{
    /// <summary>
    /// class to hold the general status of the user this is to be display on the user profile
    /// </summary>
    public class Status
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public UserStatus UserStatus { get; set; }

        public string MessageStatus { get; set; }
    }
}
