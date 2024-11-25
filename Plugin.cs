using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.Commands.PluginManager;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using Exiled.API.Interfaces;

using PluginAPI.Events;

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

            Exiled.Events.Handlers.Player.Escaping += OnEscape;
            base.OnEnabled();

            Exiled.Events.Handlers.Player.Died += OnPlayerDead;
            base.OnEnabled();

            Exiled.Events.Handlers.Server.RoundEnded += OnRoundEnd;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnVerified;
            base.OnDisabled();

            Exiled.Events.Handlers.Player.Escaping += OnEscape;
            base.OnDisabled();

            Exiled.Events.Handlers.Player.Died += OnPlayerDead;
            base.OnDisabled();

            Exiled.Events.Handlers.Server.RoundEnded += OnRoundEnd;
            base.OnDisabled();
        }
        private void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player == null && ev.Player.IsNPC && ev.Player.IsHost)
                return;

            ev.Player.Broadcast(Config.Duration, Config.Text);
        }
        private void OnEscape(EscapingEventArgs ev)
        {
            if (ev.Player == null && ev.Player.IsNPC && ev.Player.IsHost)
                return;

            ev.Player.Broadcast(Config.Duration, Config.TextEscape);
        }
        private void OnPlayerDead(DiedEventArgs ev)
        {

            if (ev.Player == null)
                return;

            ev.Player.Broadcast(Config.Duration, Config.TextDie);
        }

        private void OnRoundEnd(RoundEndedEventArgs ev)
        {
            Map.Broadcast(Config.Duration, Config.TextEndRound);
        }



    }
}
