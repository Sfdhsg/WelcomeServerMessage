using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

using Exiled.Events.EventArgs.Player;

namespace Broadcasts
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "Fatal Error 404";
        public override string Name => "WelcomeServerMesssage";
        public override string Prefix => "WelcomeServerMesssage";
        public override Version Version => base.Version;
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += OnVerified;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnVerified;
            base.OnDisabled();
        }
        private void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player == null && ev.Player.IsNPC && ev.Player.IsHost)
                return;

            ev.Player.Broadcast(Config.Duration, Config.Text);
        }
    }
}
