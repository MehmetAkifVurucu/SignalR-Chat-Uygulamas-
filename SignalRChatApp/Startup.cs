using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly:OwinStartupAttribute(typeof(SignalRChatApp.Startup))]
namespace SignalRChatApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.MapSignalR();
        }
    }
}