using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Raet.Recruitment.Desing.ChatService.MvcUI.Startup))]

namespace Raet.Recruitment.Desing.ChatService.MvcUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
