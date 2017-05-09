using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{

    /// <summary>
    /// class that maps the users to a given group
    /// </summary>
  public  class GroupUserMap
    {
        public Guid GroupId { get; set; }

        public Guid UserId { get; set; }
    }
}
