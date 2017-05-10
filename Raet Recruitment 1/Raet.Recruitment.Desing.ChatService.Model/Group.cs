using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{

    /// <summary>
    /// class to track the gruops and the creator of it
    /// </summary>
    public class Group
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid OwnerUserId { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
