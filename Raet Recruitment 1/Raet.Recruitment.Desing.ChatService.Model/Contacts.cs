using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{

    /// <summary>
    /// this class will be responsible for tracking what user requested a 
    /// connection to another user and if the target user accepted the request.
    /// </summary>
    public class Contacts
    {
        public Guid OriginatorUserId { get; set; }

        public Guid TargetUserId { get; set; }

        public bool Accepted { get; set; }


    }
}
