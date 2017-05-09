﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService.Model
{
    /// <summary>
    /// holds the user information
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

    }
}
